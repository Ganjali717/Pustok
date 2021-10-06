using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PustokTemp.Models;
using PustokTemp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PustokTemp.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context, IHttpContextAccessor contextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _contextAccessor = contextAccessor;
            _userManager = userManager;
        }

        public Setting GetSetting()
        {
            return _context.Settings.FirstOrDefault();
        }

        public List<BasketItemViewModel> GetBasketItems()
        {

            List<BasketItemViewModel> items = new List<BasketItemViewModel>();

            AppUser member = null;
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == _contextAccessor.HttpContext.User.Identity.Name && !x.IsAdmin);
            }


            if (member == null)
            {
                var itemsStr = _contextAccessor.HttpContext.Request.Cookies["Books"];

                if (itemsStr != null)
                {
                    items = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(itemsStr);

                    foreach (var item in items)
                    {
                        Book book = _context.Books.Include(c => c.BookImages).FirstOrDefault(x => x.Id == item.BookId);
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
                List<BasketItem> basketItems = _context.BasketItems.Include(x => x.Book).ThenInclude(x => x.BookImages).Where(x => x.AppUserId == member.Id).ToList();
                items = basketItems.Select(x => new BasketItemViewModel
                {
                    BookId = x.BookId,
                    Count = x.Count,
                    Image = x.Book.BookImages.FirstOrDefault(bi => bi.PosterStatus == true)?.Image,
                    Name = x.Book.Name,
                    Price = x.Book.SalePrice - x.Book.DiscountPrice
                }).ToList();
            }

            return items;
        }   
    }
}
