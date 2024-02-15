using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;
using OnlineShop.Services.Factors.Cantracts;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void AddFactor(Factor factor, int userId)
        {
           _context.Factors.Add(factor);
        }

        public User IsExistUser(int id)
        {
            return _context.Users.FirstOrDefault(_ => _.Id == id);
        }
    }
}
