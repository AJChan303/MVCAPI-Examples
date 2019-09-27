using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCdemos.Models {
    /// <summary>
    /// The product class for EF
    /// by Alex Chan
    /// 8/20/2019l
    /// look up xml documentation
    /// </summary>
    public class Product {
        [Key]
        public int Id { get; set; }

        [Required] [MaxLength(80)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Qty { get; set; }
        [MaxLength(8)]
        public string Status { get; set; }

    }
}
