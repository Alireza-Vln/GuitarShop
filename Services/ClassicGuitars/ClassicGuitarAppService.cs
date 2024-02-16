using Cantracts;
using OnlineShop.Entities;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class ClassicGuitarAppService : ClassicGuitarService
    {
       private readonly ClassicGuitarRepository _repository;
        private readonly UnitOfWork _unitOfWork;
        public ClassicGuitarAppService(ClassicGuitarRepository classicrepostory,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = classicrepostory;
        }
        public async Task AddClassic(AddClassicGuitarDto dto)
        {
            await _unitOfWork.Begin();
            try
            {
                var classic = new ClassicGuitar
                {
                    Brand = dto.Brand,
                    Model = dto.Model,
                    Count = dto.Count,
                    Price = dto.Price,


                };
                _repository.AddClassic(classic);
                await _unitOfWork.Complete();
                var guitar = new Guitar
                {
                    GuitarBrand = dto.Brand,
                    GuitarModel = dto.Model,
                    Price = dto.Price,

                };
                _repository.AddGuitar(guitar);
                await _unitOfWork.Complete();
                await _unitOfWork.Commit();

            }
            catch
            {

                await _unitOfWork.RollBack();
            }
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
            await _unitOfWork.Complete();
        }
    }
}
