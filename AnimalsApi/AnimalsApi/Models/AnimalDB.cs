using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsApi.Models {
    public class AnimalDB : DbContext {
        public DbSet<Animal> Animals { get; set; }
        public AnimalDB(DbContextOptions options) :base (options) {

        }
    }
}
