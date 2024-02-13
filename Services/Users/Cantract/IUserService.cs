using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface IUserService
    {
      public void AddUser(AddUserDto dto);
    }
}
