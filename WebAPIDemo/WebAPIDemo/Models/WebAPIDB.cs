using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.Models {

    public class WebAPIDB : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public WebAPIDB(DbContextOptions options) : base(options) { }



    }
}
