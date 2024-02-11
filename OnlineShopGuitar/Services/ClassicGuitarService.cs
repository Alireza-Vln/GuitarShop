using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class ClassicGuitarService : IClassicGuitarService
    {
       private readonly IClassicGuitarRepostory _Classicrepostory;
        public ClassicGuitarService(IClassicGuitarRepostory classicrepostory)
        {
            _Classicrepostory = classicrepostory;
        }
        public void AddClassic(AddClassicGuitarDto dto)
        {
            var classic = new ClassicGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,

            };
            _Classicrepostory.AddClassic(classic);
        }

        public List<ClassicGuitar> DeleteClassicGuitars(DeleteClassicGuitarDto dto)
        {
            return _Classicrepostory.DeleteClassicGuitars(dto.ClassicId);
        }

        public List<ClassicGuitar> GetClassicGuitars()
        {
            return _Classicrepostory.GetClassicGuitars();
        }

        public void UpdateClassicGuitar(UpdateClassicGuitarDto dto)
        {
            _Classicrepostory.UpdateClassicGuitar(dto.ClassicId,dto.ClassicPrice);
        }
    }
}
