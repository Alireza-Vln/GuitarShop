using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface IAcousticGuitarRepostory
    {
        void AddAcoustic(AcousticGuitar acoustic);
        List<AcousticGuitar> GetAllAcoustic();
    }
}
