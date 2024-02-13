using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface AcousticGuitarService
    {
        public Task AddAcoustic(AddAcousticGuitarDto dto);
        public Task <List<AcousticGuitar>> GetAllAcousticGuitars();
        public Task <List<AcousticGuitar>> DeleteAcoustic(DeleteAcousticGuitarDto dto);
        public Task UpdateAcousticGuitar(UpdateAcousticGuitarDto dto);
    }
}
