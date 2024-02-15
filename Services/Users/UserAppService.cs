using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class UserAppService : UserService
    {
        private readonly UserRepostory _UserRepostory;
        public UserAppService(UserRepostory userRepostory)
        {
            _UserRepostory = userRepostory;
        }

        public async Task AddUser(AddUserDto user)
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
