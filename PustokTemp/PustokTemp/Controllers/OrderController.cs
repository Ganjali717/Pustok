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
            checkoutVM.BasketItemViewModels = _getBasketItems();
            if (!ModelState.IsValid) return View(checkoutVM);

            AppUser member = null;

            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            Order order = new Order
            {
                FullName = checkoutVM.FullName,
                Email = checkoutVM.Email,
                Address = checkoutVM.Address,
                City = checkoutVM.City,
                Note = checkoutVM.Note,
                Phone = checkoutVM.Phone,
                Status = Models.Enums.OrderStatus.Pending,
                ZipCode = checkoutVM.ZipCode,
                CreatedAt = DateTime.UtcNow,
                OrderItems = new List<OrderItem>()
            };

            List<BasketItemViewModel> basketItemVMs = new List<BasketItemViewModel>();

            if (member == null)
            {
                var booksStr = HttpContext.Request.Cookies["Books"];
                if (booksStr != null)
                {
                    basketItemVMs = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(booksStr);
                }
            }
            else
            {
                order.AppUserId = member.Id;
                basketItemVMs = _context.BasketItems.Where(x => x.AppUserId == member.Id).Select(x => new BasketItemViewModel { BookId = x.BookId, Count = x.Count }).ToList();
            }

            foreach (var item in basketItemVMs)
            {
                Book book = _context.Books.FirstOrDefault(x => x.Id == item.BookId);

                if (book == null)
                {
                    ModelState.AddModelError("", "Selected book not found");
                    return View(checkoutVM);
                }

                _addOrderItem(ref order, book, item.Count);
            }

            if (order.OrderItems.Count == 0)
            {
                ModelState.AddModelError("", "there is not any selected book!");
                return View(checkoutVM);
            }

            _context.Orders.Add(order);
            _context.SaveChanges();

            if (member == null)
            {
                Response.Cookies.Delete("Books");
            }
            else
            {
                _context.BasketItems.RemoveRange(_context.BasketItems.Where(x => x.AppUserId == member.Id));
                _context.SaveChanges();
            }

            return RedirectToAction("index", "home");
        }

        private void _addOrderItem(ref Order order, Book book, int count)
        {
            OrderItem orderItem = new OrderItem
            {
                BookId = book.Id,
                BookName = book.Name,
                CostPrice = book.CostPrice,
                DiscountPrice = book.DiscountPrice,
                SalePrice = book.SalePrice,
                Count = count,
            };

            order.OrderItems.Add(orderItem);
            order.TotalAmount += (orderItem.SalePrice - orderItem.DiscountPrice) * orderItem.Count;
        }
        private List<BasketItemViewModel> _getBasketItems()
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (member == null)
            {
                var booksStr = HttpContext.Request.Cookies["Books"];
                if (!string.IsNullOrWhiteSpace(booksStr))
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(booksStr);

                    foreach (var item in basketItems)
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

                basketItems = _context.BasketItems.Include(x => x.Book).Where(x => x.AppUserId == member.Id)
                                                    .Select(x => new BasketItemViewModel
                                                    {
                                                        BookId = x.BookId,
                                                        Name = x.Book.Name,
                                                        Count = x.Count,
                                                        Price = x.Book.SalePrice - x.Book.DiscountPrice
                                                    }).ToList();

            }
            return basketItems;
        }
    }
}
