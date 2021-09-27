using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class BookImage
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        [StringLength(maximumLength:100)]
        public string Image { get; set; }
        public bool? PosterStatus { get; set; }
        public Book Book { get; set; }
    }
}
