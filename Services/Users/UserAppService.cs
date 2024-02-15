using Cantracts;
using OnlineShop.Entities;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class UserAppService : UserService
    {
        private readonly UserRepository _UserRepostory;
        private readonly UnitOfWork _unitOfWork;
        public UserAppService(UserRepository userRepostory,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _UserRepostory = userRepostory;
        }

        public async Task AddUser(AddUserDto dto)
        {
            var User = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Address = dto.Adderss,
                //Factors = new(),
            };
            _UserRepostory.AddUser(User);
            await _unitOfWork.Complete();
        }
    }
}
