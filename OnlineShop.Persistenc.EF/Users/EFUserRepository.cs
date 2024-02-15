
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFUserRepository : UserRepository
    {
        private readonly EfDbContext _Context;
        public EFUserRepository(EfDbContext context)
        {  
            _Context = context;
        }
        public void AddUser(User user)
        {
            _Context.Users.Add(user);
           
        }
    }
}
