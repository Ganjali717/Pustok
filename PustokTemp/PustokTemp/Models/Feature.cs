using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Logo { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Subtitle { get; set; }
        public int Order { get; set; }
    }
}
