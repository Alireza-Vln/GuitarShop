using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Entities;
using OnlineShop.Services.Factors.Cantracts;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Persistence.EF.Factors
{
    public class EFFactorRpository : FactorRepository
    {
        readonly EfDbContext _context;
        public EFFactorRpository(EfDbContext context)
        {
            _context = context;
        }
        public void AddFactor(Factor factor)
        {
           _context.Factors.Add(factor);
        }

        public User IsExistUser(int id)
        {
            return _context.Users.FirstOrDefault(_ => _.Id == id);
        }

        public Guitar IsExistGuitar(string brand, string model)
        {
            return _context.Guitars.
                FirstOrDefault(_=>_.GuitarBrand==brand && _.GuitarModel==model);
   
        }
    }
}
