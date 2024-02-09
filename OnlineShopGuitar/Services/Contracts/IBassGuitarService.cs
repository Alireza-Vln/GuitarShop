using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface IBassGuitarService
    {
         void AddBass(AddGuitarBassDto dto);
    }
}
