using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsApi.Models {
    public class Animal {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(1)]
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }

    }
}
