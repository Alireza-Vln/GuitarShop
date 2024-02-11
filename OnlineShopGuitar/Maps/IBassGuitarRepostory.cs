using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface IBassGuitarRepostory
    {
        void AddBass(BassGuitar bassGuitar);
        List<BassGuitar> GetAllBassGuitar();
        List<BassGuitar> DeleteBassGuitar(int id);
        void UpdateBassPrice(int id,decimal price);
        

    }
}
