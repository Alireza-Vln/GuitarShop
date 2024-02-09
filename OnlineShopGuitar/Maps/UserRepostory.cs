using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class UserRepostory : IUserRepostory
    {
        private readonly EfDbContext _Context;
        public UserRepostory(EfDbContext context)
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
