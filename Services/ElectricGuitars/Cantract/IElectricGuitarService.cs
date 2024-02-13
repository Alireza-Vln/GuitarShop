using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface IElectricGuitarService
    {
        public void AddElectric(AddElecetricGuitarDto dto);
        List <ElectircGuitar> GetElectircGuitars();
        List <ElectircGuitar> DeleteElectircGuitars(DeleteElectricGuitarDto dto);
        public void UpdateElectircGuitar(UpdateElectricGuitarDto dto);
    }
}
