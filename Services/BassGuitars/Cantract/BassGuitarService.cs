using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface BassGuitarService
    {
         Task AddBass(AddGuitarBassDto dto);
        Task <List<BassGuitar>> GetAllBassGuitars();
        Task <List<BassGuitar>> DeleteBassGuitar(DeleteBassGuitarDto dto);
        Task UpdateBassGuitar(UpdateBassGuitarPriceDto dto);
    }
}
