
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFUserRepostory : UserRepostory
    {
        private readonly EfDbContext _Context;
        public EFUserRepostory(EfDbContext context)
        {  
            _Context = context;
        }
        public void AddUser(User user)
        {
            _Context.Users.Add(user);
            _Context.SaveChanges();
        }
    }
}
