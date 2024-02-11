using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface IClassicGuitarService
    {
        public void AddClassic(AddClassicGuitarDto dto);
        public List<ClassicGuitar> GetClassicGuitars();
        public List<ClassicGuitar> DeleteClassicGuitars(DeleteClassicGuitarDto dto);
        public void UpdateClassicGuitar(UpdateClassicGuitarDto dto);
    }
}
