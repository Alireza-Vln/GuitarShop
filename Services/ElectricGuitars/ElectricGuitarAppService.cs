using Cantracts;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class ElectricGuitarAppService : ElectricGuitarService
    {
        private readonly ElectriceGuitarRepository _repository;
        private readonly UnitOfWork _unitOfWork;
        public ElectricGuitarAppService(ElectriceGuitarRepository electriceGuitar,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = electriceGuitar;
        }
        public async Task AddElectric(AddElecetricGuitarDto dto)
        {
            var electric = new ElectricGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,
            };
            _repository.AddElectric(electric);
            await _unitOfWork.Complete();
        }

        public async Task<List<ElectricGuitar>> DeleteElectircGuitars(DeleteElectricGuitarDto dto)
        {
            if(_repository.ISExistGuitar(dto.ElectricId)==null)
            {
                throw new Exception("not Found");
            }

            return _repository.DeleteElectircGuitars
                (_repository.ISExistGuitar(dto.ElectricId));
            
        }

        public async Task<List<ElectricGuitar>> GetElectircGuitars()
        {
            return _repository.GetElectric();
        }

    
        public async Task UpdateElectircGuitar(UpdateElectricGuitarDto dto)
        {
            if (_repository.ISExistGuitar(dto.ElectricId) == null)
            {
                throw new Exception("not Found");
            }
            _repository.UpadateElectricGuitarPrice
                (_repository.ISExistGuitar(dto.ElectricId), dto.ElectricePrice);
            await _unitOfWork.Complete();

        }
    }
}
