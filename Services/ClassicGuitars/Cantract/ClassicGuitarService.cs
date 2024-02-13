using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Services.Contracts
{
    public interface ClassicGuitarService
    {
        public Task AddClassic(AddClassicGuitarDto dto);
        public Task<List<ClassicGuitar>>GetClassicGuitars();
        public Task<List<ClassicGuitar>> DeleteClassicGuitars(DeleteClassicGuitarDto dto);
        public Task UpdateClassicGuitar(UpdateClassicGuitarDto dto);
    }
}
