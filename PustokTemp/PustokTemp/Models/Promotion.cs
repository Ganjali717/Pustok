﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
    }
}
