using Cantracts;
using OnlineShopGuitar.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Persistence.EF
{
    public class EFUnitOfWork : UnitOfWork
    {
        private readonly EfDbContext _Context;
        public EFUnitOfWork(EfDbContext context)
        {
                _Context = context;
        }
        public async Task Begin()
        {
           await _Context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _Context.Database.CommitTransactionAsync();
        }

        public async Task Complete()
        {
            await _Context.SaveChangesAsync();
        }

        public async Task RollBack()
        {
            await _Context.Database.RollbackTransactionAsync();
        }
    }
}
