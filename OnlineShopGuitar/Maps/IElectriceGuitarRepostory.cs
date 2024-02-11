using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface IElectriceGuitarRepostory
    {
        void AddElectric(ElectircGuitar electircGuitar);
        List <ElectircGuitar> GetElectric();
        List <ElectircGuitar> DeleteElectircGuitars(int Id);
        void UpadateElectricGuitarPrice(int Id,decimal Price);
    }
}
