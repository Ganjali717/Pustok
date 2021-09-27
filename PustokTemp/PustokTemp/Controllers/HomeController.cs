using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PustokTemp.Models;
using PustokTemp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
/*
            string username = HttpContext.Session.GetString("username");

            ViewBag.username = username;
            ViewBag.SelectedBook = HttpContext.Request.Cookies["BookName"];*/


            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Features = _context.Features.OrderBy(x => x.Order).ToList(),
                Promotions = _context.Promotions.ToList(),
                FeaturedBooks = _context.Books.Include(x => x.BookImages).Include(x => x.Author).Where(x => x.IsFeatured).Take(10).ToList(),
                NewBooks = _context.Books.Include(x => x.BookImages).Include(x => x.Author).Where(x => x.IsNew).Take(10).ToList(),
                DiscountedBooks = _context.Books.Include(x => x.BookImages).Include(x => x.Author).Where(x => x.DiscountPrice > 0).Take(10).ToList(), 
                BrandSlides = _context.BrandSlides.OrderBy(x => x.Order).ToList()
            };

            return View(homeVM);
        }

        public IActionResult GetBook(int id)
        {
            Book book = _context.Books
                .Include(x => x.BookImages).Include(x => x.Genre)
                .Include(x => x.BookTags).ThenInclude(x => x.Tag)
                .FirstOrDefault(x => x.Id == id);

            return PartialView("_BookModalPartial", book);
        }


        public IActionResult SetSession(string name)
        {
            HttpContext.Session.SetString("username", name);

            return RedirectToAction("index");
        }

        public IActionResult GetSession()
        {
            string username = HttpContext.Session.GetString("username");

            return Content(username);
        }

        public IActionResult SetCookie(int id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == id);

            HttpContext.Response.Cookies.Append("BookName", book.Name);

            return RedirectToAction("index");
        }

        public IActionResult GetCookie()
        {
            string kitab = HttpContext.Request.Cookies["BookName"];

            return Content(kitab);
        }

        public IActionResult AddCount(int num)
        {
            

            int count = num;

            if (HttpContext.Request.Cookies["total"] != null)
            {
                count = Convert.ToInt32(HttpContext.Request.Cookies["total"]);
                count += num;
            }
            HttpContext.Response.Cookies.Append("total", count.ToString());
            return Content("");
        }

        public IActionResult ShowCount()
        {
            int count = Convert.ToInt32(HttpContext.Request.Cookies["total"]);

            return Content(count.ToString());
        }

        public IActionResult AddBook(int id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == id);

            List<string> names = new List<string>();


            string namesStr;
            if (HttpContext.Request.Cookies["BookNames"] != null)
            {
                namesStr = HttpContext.Request.Cookies["BookNames"];
                names = JsonConvert.DeserializeObject<List<string>>(namesStr);
            }
            names.Add(book.Name);
            namesStr = JsonConvert.SerializeObject(names);
            HttpContext.Response.Cookies.Append("BookNames", namesStr);
            return Content("");

        }

        public IActionResult ShowBook()
        {
            var booksStr = HttpContext.Request.Cookies["BookNames"];

            return Content(booksStr);
           /* List<string> books = JsonConvert.DeserializeObject<List<string>>(booksStr);

            return View(books);*/
        }

       /* public IActionResult DeleteBook(string key)
        {
            HttpContext.Response.Cookies.Delete(key);
            return RedirectToAction("index");

        }*/
    }
}
