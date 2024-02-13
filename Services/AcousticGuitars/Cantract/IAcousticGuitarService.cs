using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface IAcousticGuitarService
    {
        public void AddAcoustic(AddAcousticGuitarDto dto);
        public List<AcousticGuitar> GetAllAcousticGuitars();
        public List<AcousticGuitar> DeleteAcoustic(DeleteAcousticGuitarDto dto);
        public void UpdateAcousticGuitar(UpdateAcousticGuitarDto dto);
    }
}
