using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Xahis olunur adinizi qeyd eliyin!")]
        [StringLength(maximumLength:50)]
        public string FullName { get; set; }
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        public List<Book> Books { get; set; }
    }
}
