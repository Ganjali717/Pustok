using PustokTemp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.ViewModels
{
    public class BasketItemViewModel
    {
        public int BookId { get; set; }
        public string Image { get; set; }
        public string HoverImage { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
