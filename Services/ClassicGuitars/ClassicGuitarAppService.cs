using Cantracts;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class ClassicGuitarAppService : ClassicGuitarService
    {
       private readonly ClassicGuitarRepository _repository;
        private readonly UnitOfWork _UnitOfWork;
        public ClassicGuitarAppService(ClassicGuitarRepository classicrepostory,UnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
            _repository = classicrepostory;
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
            _repository.AddClassic(classic);
            await _UnitOfWork.Complete();
        }

        public async Task <List<ClassicGuitar>> DeleteClassicGuitars(DeleteClassicGuitarDto dto)
        {
            if (_repository.IsExistGuitar(dto.ClassicId) == null)
            {
                throw new Exception("Not found");
            }
            return _repository.DeleteClassicGuitars
                (_repository.IsExistGuitar(dto.ClassicId));
        }

        public async Task <List<ClassicGuitar>> GetClassicGuitars()
        {
            return _repository.GetClassicGuitars();
        }

        public async Task UpdateClassicGuitar(UpdateClassicGuitarDto dto)
        {
            if (_repository.IsExistGuitar(dto.ClassicId) == null)
            {
                throw new Exception("Not found");
            }
            _repository.UpdateClassicGuitar(_repository.IsExistGuitar(dto.ClassicId), dto.ClassicPrice);
            await _UnitOfWork.Complete();
        }
    }
}
