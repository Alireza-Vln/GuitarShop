using Cantracts;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class ClassicGuitarAppService : ClassicGuitarService
    {
       private readonly ClassicGuitarRepostory _Classicrepostory;
        private readonly UnitOfWork _UnitOfWork;
        public ClassicGuitarAppService(ClassicGuitarRepostory classicrepostory,UnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
            _Classicrepostory = classicrepostory;
        }
        public async Task AddClassic(AddClassicGuitarDto dto)
        {
            var classic = new ClassicGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,

            };
            _Classicrepostory.AddClassic(classic);
            await _UnitOfWork.Complete();
        }

        public async Task <List<ClassicGuitar>> DeleteClassicGuitars(DeleteClassicGuitarDto dto)
        {
            return _Classicrepostory.DeleteClassicGuitars(dto.ClassicId);
        }

        public async Task <List<ClassicGuitar>> GetClassicGuitars()
        {
            return _Classicrepostory.GetClassicGuitars();
        }

        public async Task UpdateClassicGuitar(UpdateClassicGuitarDto dto)
        {
            _Classicrepostory.UpdateClassicGuitar(dto.ClassicId,dto.ClassicPrice);
            await _UnitOfWork.Complete();
        }
    }
}
