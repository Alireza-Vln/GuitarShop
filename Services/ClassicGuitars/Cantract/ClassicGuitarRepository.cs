using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface ClassicGuitarRepository
    {
        public ClassicGuitar IsExistGuitar(int id);
        void AddClassic(ClassicGuitar classicGuitar);
        void AddGuitar(Guitar guitar);
        public List<ClassicGuitar> GetClassicGuitars();
        public List<ClassicGuitar> DeleteClassicGuitars(ClassicGuitar classicGuitar);
        public void UpdateClassicGuitar(ClassicGuitar classicGuitar, decimal price);
    }
}
