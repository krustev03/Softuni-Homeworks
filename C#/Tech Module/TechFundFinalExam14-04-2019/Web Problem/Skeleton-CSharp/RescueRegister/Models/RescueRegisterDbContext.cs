﻿using Microsoft.EntityFrameworkCore;

namespace RescueRegister.Models
{
    public class RescueRegisterDbContext:DbContext
    {
        public RescueRegisterDbContext()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Mountaineer> Mountaineers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4PK0GK7\SQLEXPRESS;Database=RescueRegister;Integrated Security=True");
        }
    }
}
