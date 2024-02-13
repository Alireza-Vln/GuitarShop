using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepostory _UserRepostory;
        public UserService(IUserRepostory userRepostory)
        {
            _UserRepostory = userRepostory;
        }

        public void AddUser(AddUserDto user)
        {
            var User = new User()
            {
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
            };
            _UserRepostory.AddUser(User);
        }
    }
}
