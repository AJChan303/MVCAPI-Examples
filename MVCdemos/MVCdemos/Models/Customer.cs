using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCdemos.Models
{
    public class Customer
    {   [Key]public int Id { get; set; }
        

               
        [Required][MaxLength(30)] [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime Added { get; set; }

        public decimal CreditLimit { get; set; }



    }
}
