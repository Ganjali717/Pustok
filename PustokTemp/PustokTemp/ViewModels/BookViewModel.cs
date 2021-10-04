
using PustokTemp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.ViewModels
{
    public class BookViewModel
    {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Tag> Tags { get; set; }
        public double MaxPrice { get; set; }
        public double MinPrice { get; set; }
    }
}
