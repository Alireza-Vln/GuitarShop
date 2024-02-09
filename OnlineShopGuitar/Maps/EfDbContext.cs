﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EfDbContext:DbContext
    {
        public DbSet<BassGuitar> BassGuitars { get; set; }
        public DbSet<ElectircGuitar> ElectricGuitars { get; set; }
        public DbSet<ClassicGuitar> ClassicGuitars { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GuitarDB2;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
