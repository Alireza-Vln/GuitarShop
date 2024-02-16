using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface AcousticGuitarRepository
    {


        public AcousticGuitar IsExistGuitar(int id);
        
        void AddAcoustic(AcousticGuitar acoustic);
        void AddGuitar(Guitar guitar);
        List<AcousticGuitar> GetAllAcoustic();
        List<AcousticGuitar> DeleteAcoustic(AcousticGuitar acousticGuitar);
        void UpadateAcoustic(AcousticGuitar acousticGuitar,decimal price);
        

    }
}
