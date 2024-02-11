using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface IBassGuitarService
    {
         void AddBass(AddGuitarBassDto dto);
        List<BassGuitar> GetAllBassGuitars();
        List<BassGuitar> DeleteBassGuitar(DeleteBassGuitarDto dto);
        void UpdateBassGuitar(UpdateBassGuitarPriceDto dto);
    }
}
