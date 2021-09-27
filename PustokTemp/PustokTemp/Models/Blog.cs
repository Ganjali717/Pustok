using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string RedirectId { get; set; }
    }
}
