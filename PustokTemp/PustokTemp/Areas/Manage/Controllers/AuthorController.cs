    using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokTemp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AuthorController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Author> authors = _context.Authors.Include(x => x.Books).ToList();
            return View(authors);
        }
        public IActionResult ShowBook()
        {
            List<Book> books = _context.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (author.ImageFile != null)
            {
                if (author.ImageFile.ContentType != "image/jpeg" && author.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Content type can be only jpeg or png!");
                    return View();
                }

                if (author.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2mb!");
                    return View();
                }


                string filename = author.ImageFile.FileName;
                if (filename.Length > 64)
                {
                    filename = filename.Substring(filename.Length - 64, 64);
                }
                string newFileName = Guid.NewGuid().ToString() + filename;

                string path = Path.Combine(_env.WebRootPath, "uploads/author", newFileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    author.ImageFile.CopyTo(stream);
                }

                author.Image = newFileName;
            }

            _context.Add(author);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            Author existAuthor = _context.Authors.FirstOrDefault(x => x.Id == author.Id);

            if (existAuthor == null) return NotFound();

            existAuthor.FullName = author.FullName;

            if (author.ImageFile != null)
            {
                if (author.ImageFile.ContentType != "image/jpeg" && author.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Content type can be only jpeg or png!");
                    return View();
                }

                if (author.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2mb!");
                    return View();
                }


                string filename = author.ImageFile.FileName;
                if (filename.Length > 64)
                {
                    filename = filename.Substring(filename.Length - 64, 64);
                }
                string newFileName = Guid.NewGuid().ToString() + filename;

                string path = Path.Combine(_env.WebRootPath, "uploads/author", newFileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    author.ImageFile.CopyTo(stream);
                }

                if (existAuthor.Image != null)
                {
                    string deletePath = Path.Combine(_env.WebRootPath, "uploads/author", existAuthor.Image);

                    if (System.IO.File.Exists(deletePath))
                    {
                        System.IO.File.Delete(deletePath);
                    }
                }


                existAuthor.Image = newFileName;
            }
            else if (author.Image == null && existAuthor.Image != null)
            {
                string deletePath = Path.Combine(_env.WebRootPath, "uploads/author", existAuthor.Image);

                if (System.IO.File.Exists(deletePath))
                {
                    System.IO.File.Delete(deletePath);
                }

                existAuthor.Image = null;
            }

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Id == id);

            if (author == null) return NotFound();

            return View(author);
        }

        public IActionResult DeleteAuthor(int id)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Id == id);

            if (author == null) return NotFound();

            _context.Authors.Remove(author);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult DeleteFetch(int id)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Id == id);

            if (author == null) return Json(new { status = 404 });

            try
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return Json(new { status = 500 });
            }

            return Json(new { status = 200 });
        }

        
    }
}
