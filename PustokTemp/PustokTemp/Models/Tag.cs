using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class Tag
    {
        public int  Id { get; set; }
        [StringLength(maximumLength:20)]
        public string Name { get; set; }

        public List<BookTag> BookTags { get; set; }
    }
}
