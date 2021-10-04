using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PustokTemp.ViewModels;
using PustokTemp.Models;
using PustokTemp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
           
            BookViewModel bookVM = new BookViewModel
            {
                Books = _context.Books.Include(x => x.BookImages).Include(x => x.Author).Skip((page - 1) * 4).Take(6).ToList(),
                Authors = _context.Authors.Include(x => x.Books).ToList(),
                Genres = _context.Genres.Include(x => x.Books).ToList(),
                MaxPrice = _context.Books.Max(x => x.SalePrice),
                MinPrice = _context.Books.Min(x => x.SalePrice),
                Tags = _context.Tags.Include(x => x.BookTags).ToList(),

            };

            ViewBag.TotalPage = Math.Ceiling(_context.Books.Count() / 4m);
            ViewBag.SelectedPage = page;
            return View(bookVM);
        }

        public IActionResult FilterGenre(int id)
        {
            List<Book> book = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.GenreId == id).ToList();
            if (book == null) return NotFound();
            return PartialView("_BookPartial", book);
        }
        public IActionResult AddBasket(int id)
        {
            Book book = _context.Books.Include(x => x.BookImages).FirstOrDefault(x => x.Id == id);
            BasketItemViewModel basketItem = null;

            if (book == null) return NotFound();

            List<BasketItemViewModel> books = new List<BasketItemViewModel>();
            string booksStr;
            if (HttpContext.Request.Cookies["Books"] != null)
            {
                booksStr = HttpContext.Request.Cookies["Books"];
                books = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(booksStr);

                basketItem = books.FirstOrDefault(x => x.BookId == id);

                if (basketItem != null)
                {
                    basketItem.Count++;
                }
                else
                {
                    basketItem = new BasketItemViewModel()
                    {
                        BookId = book.Id,
                        Name = book.Name,
                        Price = (book.SalePrice - book.DiscountPrice),
                        Image = book.BookImages.FirstOrDefault(x => x.PosterStatus == true).Image,
                        Count = 1
                    };
                    books.Add(basketItem);
                }
            }

             booksStr = JsonConvert.SerializeObject(books);
            HttpContext.Response.Cookies.Append("Books", booksStr);

            return PartialView("_BasketPartial", books);
        }

        public IActionResult ShowBasket()
        {
            var booksStr = HttpContext.Request.Cookies["Books"];

            return Content(booksStr);
        }

        public IActionResult DeleteBook(int id)
        {
            BasketItemViewModel basketItem = new BasketItemViewModel();
          
            List<BasketItemViewModel> books = new List<BasketItemViewModel>();
          
            string booksStr;


            booksStr = HttpContext.Request.Cookies["Books"];
            books = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(booksStr);
            basketItem = books.FirstOrDefault(x => x.BookId == id);

            books.Remove(basketItem);
            booksStr = JsonConvert.SerializeObject(books);

            HttpContext.Response.Cookies.Append("Books", booksStr);

            /*return RedirectToAction("index", "home");*/

            return PartialView("_BasketPartial", books);    
        }

        public IActionResult Detail(int id)
        {
            Book book = _context.Books.Include(x => x.BookImages).Include(x => x.BookTags).ThenInclude(x => x.Tag).Include(x => x.Genre).FirstOrDefault(x => x.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

    }

}
