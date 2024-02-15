using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface ElectricGuitarService
    {
        public Task AddElectric(AddElecetricGuitarDto dto);
        Task<List <ElectricGuitar>> GetElectircGuitars();
        Task<List <ElectricGuitar>> DeleteElectircGuitars(DeleteElectricGuitarDto dto);
        public Task UpdateElectircGuitar(UpdateElectricGuitarDto dto);
    }
}
