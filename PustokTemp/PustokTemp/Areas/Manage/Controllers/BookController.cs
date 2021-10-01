using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokP123.Helpers;
using PustokTemp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
      
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BookController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page=1)
        {
            List<Book> books = _context.Books.Include(x => x.Author).Include(x => x.Genre).Include(x => x.BookImages).Skip((page - 1) * 4).Take(4).ToList();

            ViewBag.TotalPage = Math.Ceiling(_context.Books.Count() / 4m);
            ViewBag.SelectedPage = page;

            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!_context.Authors.Any(x => x.Id == book.AuthorId)) ModelState.AddModelError("AuthorId", "Author not found!");
            if (!_context.Genres.Any(x => x.Id == book.GenreId)) ModelState.AddModelError("GenreId", "Genre not found!");

            book.BookImages = new List<BookImage>();
            book.BookTags = new List<BookTag>();
            foreach (var tagId in book.TagIds)
            {
                Tag tag = _context.Tags.FirstOrDefault(x => x.Id == tagId);

                if (tag == null)
                {
                    ModelState.AddModelError("TagIds", "Tag not found!");
                    return View();
                }

                BookTag bookTag = new BookTag       
                {
                    TagId = tagId
                };

                book.BookTags.Add(bookTag);
            }

            if (book.PosterFile == null)
            {
                ModelState.AddModelError("PosterFile", "Poster file is required");
            }
            else
            {
                if (book.PosterFile.ContentType != "image/png" && book.PosterFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("PosterFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (book.PosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("PosterFile", "File size can not be more than 2MB!");
                    return View();
                }

                string newFileName = Guid.NewGuid().ToString() + book.PosterFile.FileName;
                string path = Path.Combine(_env.WebRootPath, "uploads/book", newFileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    book.PosterFile.CopyTo(stream);
                }

                BookImage poster = new BookImage
                {
                    Image = newFileName,
                    PosterStatus = true,
                };
                book.BookImages.Add(poster);
            }

            if (book.HoverPosterFile == null)
            {
                ModelState.AddModelError("HoverPosterFile", "Poster file is required");
            }
            else
            {
                if (book.HoverPosterFile.ContentType != "image/png" && book.HoverPosterFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("HoverPosterFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (book.HoverPosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("HoverPosterFile", "File size can not be more than 2MB!");
                    return View();
                }

                string newFileName = Guid.NewGuid().ToString() + book.PosterFile.FileName;
                string path = Path.Combine(_env.WebRootPath, "uploads/book", newFileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    book.HoverPosterFile.CopyTo(stream);
                }

                BookImage hover = new BookImage
                {
                    Image = newFileName,
                    PosterStatus = false,
                };
                book.BookImages.Add(hover);
            }

            if (book.ImageFiles != null)
            {
                foreach (var file in book.ImageFiles)
                {
                    if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                    {
                        continue;
                    }

                    if (file.Length > 2097152)
                    {
                        continue;
                    }

                    BookImage image = new BookImage
                    {
                        PosterStatus = null,
                        Image = FileManager.Save(_env.WebRootPath, "uploads/book", file)
                    };

                    book.BookImages.Add(image);
                }
            }

            if (!ModelState.IsValid) return View();

            _context.Books.Add(book);
            _context.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult Edit(int id)
        {
            Book book = _context.Books.Include(b => b.BookImages).Include(t => t.BookTags).FirstOrDefault(x => x.Id == id);
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Genres = _context.Genres.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            book.TagIds = book.BookTags.Select(x => x.TagId).ToList();
            if (book == null) return NotFound();    
            return View(book);
        }
        
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!_context.Authors.Any(x => x.Id == book.AuthorId)) ModelState.AddModelError("AuthorId", "Author not found!");
            if (!_context.Genres.Any(x => x.Id == book.GenreId)) ModelState.AddModelError("GenreId", "Genre not found!");


            Book existBook = _context.Books.Include(b=>b.BookImages).Include(t => t.BookTags).FirstOrDefault(x => x.Id == book.Id);

         


            existBook.Name = book.Name;
            existBook.Code = book.Code;
            existBook.AuthorId = book.AuthorId;
            existBook.GenreId = book.GenreId;
            existBook.CostPrice = book.CostPrice;
            existBook.SalePrice = book.SalePrice;
            existBook.DiscountPrice = book.DiscountPrice;
            existBook.PageCount = book.PageCount;
            existBook.Desc = book.Desc;
            existBook.InfoText = book.InfoText;
            existBook.Rate = book.Rate;
            existBook.IsAvailable = book.IsAvailable;
            existBook.IsFeatured = book.IsFeatured;
            existBook.IsNew = book.IsNew;
            existBook.BookTags = book.BookTags;

            if (book.PosterFile != null)
            {
                if (book.PosterFile.ContentType != "image/jpeg" && book.PosterFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Content type can be only jpeg or png!");
                    return View();
                }

                if (book.PosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2mb!");
                    return View();
                }


                string filename = book.PosterFile.FileName;
                if (filename.Length > 64)
                {
                    filename = filename.Substring(filename.Length - 64, 64);
                }
                string newFileName = Guid.NewGuid().ToString() + filename;

                string path = Path.Combine(_env.WebRootPath, "uploads/book", newFileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    book.PosterFile.CopyTo(stream);
                }

                if (existBook.BookImages.FirstOrDefault(x=>x.PosterStatus == true).Image != null)
                {
                    string deletePath = Path.Combine(_env.WebRootPath, "uploads/book", existBook.BookImages.FirstOrDefault(x => x.PosterStatus == true)?.Image);

                    if (System.IO.File.Exists(deletePath))
                    {
                        System.IO.File.Delete(deletePath);
                    }
                }


                existBook.BookImages.FirstOrDefault(x => x.PosterStatus == true).Image = newFileName;
            }
            else if (existBook.BookImages.FirstOrDefault(x => x.PosterStatus == true).Image != null)
            {
                string deletePath = Path.Combine(_env.WebRootPath, "uploads/author", existBook.BookImages.FirstOrDefault(x => x.PosterStatus == true).Image);

                if (System.IO.File.Exists(deletePath))
                {
                    System.IO.File.Delete(deletePath);
                }

                existBook.BookImages.FirstOrDefault(x => x.PosterStatus == true).Image = null;
            }

            existBook.BookImages.RemoveAll(x => x.PosterStatus == null && !book.BookImageIds.Contains(x.Id));

            if (book.ImageFiles != null)
            {
                foreach (var file in book.ImageFiles)
                {
                    if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                    {
                        continue;
                    }

                    if (file.Length > 2097152)
                    {
                        continue;
                    }

                    BookImage image = new BookImage
                    {
                        PosterStatus = null,
                        Image = FileManager.Save(_env.WebRootPath, "uploads/book", file)
                    };

                    existBook.BookImages.Add(image);
                }
            }
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Book book = _context.Books.Include(b => b.BookImages).FirstOrDefault(x => x.Id == id);
            if (book == null) return NotFound();
            
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Genres = _context.Genres.ToList();
            return View(book);
        }


        public IActionResult DeleteBookFetch(int id)
        {
            Book book = _context.Books.Include(b => b.BookImages).FirstOrDefault(x => x.Id == id);
            if (book == null) return Json(new { status = 404 });

            try
            {
                _context.Books.Remove(book);
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
