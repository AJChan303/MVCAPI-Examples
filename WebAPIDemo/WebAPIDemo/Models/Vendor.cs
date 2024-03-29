﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.Models {
    public class Vendor {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(16)]
        public string City { get; set; }
        [MaxLength(2)]
        public string Ohio { get; set; }
        [MaxLength(10)]
        public string Zip { get; set; }



    }
}
