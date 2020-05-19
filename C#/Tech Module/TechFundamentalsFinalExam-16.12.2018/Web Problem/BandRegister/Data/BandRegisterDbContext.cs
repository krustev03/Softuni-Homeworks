using BandRegister.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandRegister.Data
{
    public class BandRegisterDbContext:DbContext
    {
        public DbSet<Band> Bands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4PK0GK7\SQLEXPRESS;Database=BandRegisterDb;Integrated Security=True;");
        }
    }
}
