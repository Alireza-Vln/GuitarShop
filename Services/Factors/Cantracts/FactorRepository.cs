using OnlineShop.Entities;
using OnlineShopGuitar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Factors.Cantracts
{
  public interface FactorRepository
    {
        public User IsExistUser (int id);
        public Guitar IsExistGuitar(string brand, string model);
        void AddFactor(Factor factor);

    }
}
