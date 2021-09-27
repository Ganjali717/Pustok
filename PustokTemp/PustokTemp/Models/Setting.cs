using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string HeaderLogo { get; set; }
        [StringLength(50)]
        public string FooterLogo { get; set; }
        [StringLength(50)]
        public string SupportPhone { get; set; }
        [StringLength(50)]
        public string ContactPhone { get; set; }
        [StringLength(100)]
        public string ContactEmail { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
    }
}
