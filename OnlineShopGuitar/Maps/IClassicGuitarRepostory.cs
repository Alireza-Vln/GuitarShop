using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface IClassicGuitarRepostory
    {
        void AddClassic(ClassicGuitar classicGuitar);
        public List<ClassicGuitar> GetClassicGuitars();
        public List<ClassicGuitar> DeleteClassicGuitars(int id);
        public void UpdateClassicGuitar(int id, decimal price);
    }
}
