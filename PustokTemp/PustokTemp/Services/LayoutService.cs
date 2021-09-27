using Microsoft.AspNetCore.Http;
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
        public LayoutService(AppDbContext context, IHttpContextAccessor contextAccessor )
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public Setting GetSetting()
        {
            return _context.Settings.FirstOrDefault();
        }

        public List<BasketItemViewModel> GetBasketItems()
        {
            var itemsStr = _contextAccessor.HttpContext.Request.Cookies["Books"];

            List<BasketItemViewModel> items = new List<BasketItemViewModel>();

            if (itemsStr != null)
            {
                items = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(itemsStr);

                foreach (var item in items)
                {
                    Book book = _context.Books.FirstOrDefault(x => x.Id == item.BookId);

                    item.Price = book.SalePrice - book.DiscountPrice;
                }
            }

            return items;
        }   
    }
}
