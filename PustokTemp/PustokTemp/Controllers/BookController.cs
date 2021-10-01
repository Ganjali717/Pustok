using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

    }

}
