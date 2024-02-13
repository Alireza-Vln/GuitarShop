using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface UserService
    {
      public void AddUser(AddUserDto dto);
    }
}
