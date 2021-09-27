using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
