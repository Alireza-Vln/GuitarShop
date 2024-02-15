using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EfDbContext:DbContext
    {
        public DbSet<BassGuitar> BassGuitars { get; set; }
        public DbSet<ElectricGuitar> ElectricGuitars { get; set; }
        public DbSet<ClassicGuitar> ClassicGuitars { get; set; }
        public DbSet<AcousticGuitar> AcousticGuitars { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GuitarDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
