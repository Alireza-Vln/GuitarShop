using OnlineShop.Services.Factors.Cantracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Factors.Cantracts
{
    public interface FactorService
    {
        public Task AddFactor(int userId,
            string brand,string model);
    }
}
