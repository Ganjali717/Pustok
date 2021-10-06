using Microsoft.AspNetCore.Identity;
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
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Checkout()
        {
            CheckoutViewModel checkoutVM = new CheckoutViewModel();

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if(member == null)
            {
                var booksStr = HttpContext.Request.Cookies["Books"];
                if (!string.IsNullOrWhiteSpace(booksStr))
                {
                    checkoutVM.BasketItemViewModels = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(booksStr);

                    foreach (var item in checkoutVM.BasketItemViewModels)
                    {
                        Book book = _context.Books.Include(x => x.BookImages).FirstOrDefault(x => x.Id == item.BookId);
                        if (book != null)
                        {
                            item.Name = book.Name;
                            item.Price = book.SalePrice - book.DiscountPrice;
                            item.Image = book.BookImages.FirstOrDefault(x => x.PosterStatus == true)?.Image;
                        }
                    }
                }
            }
            else
            {
                checkoutVM.Email = member.Email;
                checkoutVM.FullName = member.Fullname;
                checkoutVM.Phone = member.PhoneNumber;

                checkoutVM.BasketItemViewModels = _context.BasketItems.Include(x => x.Book).Where(x => x.AppUserId == member.Id)
                                                   .Select(x => new BasketItemViewModel
                                                   {
                                                       BookId = x.BookId,
                                                       Name = x.Book.Name,
                                                       Count = x.Count,
                                                       Price = x.Book.SalePrice - x.Book.DiscountPrice
                                                   }).ToList();

            }

            return View(checkoutVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(CheckoutViewModel checkoutVM)
        {
            return Ok(checkoutVM);
        }
    }
}
