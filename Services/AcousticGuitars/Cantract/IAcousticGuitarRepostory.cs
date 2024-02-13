using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface IAcousticGuitarRepostory
    {
        void AddAcoustic(AcousticGuitar acoustic);
        List<AcousticGuitar> GetAllAcoustic();
        List<AcousticGuitar> DeleteAcoustic(int Id);
        void UpadateAcoustic(int id, decimal price);
        

    }
}
