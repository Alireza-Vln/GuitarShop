using Cantracts;
using OnlineShop.Entities;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class BassGuitarAppService : BassGuitarService
    {
        private readonly BassGuitarRepository _repository;
        private readonly UnitOfWork _unitOfWork;

        public BassGuitarAppService(BassGuitarRepository bassGuitarRepostory,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = bassGuitarRepostory;
        }

        public async Task AddBass(AddGuitarBassDto dto)
        {
            await _unitOfWork.Begin();
            try
            {
                var bass = new BassGuitar
                {
                    Brand = dto.Brand,
                    Model = dto.Model,
                    Count = dto.Count,
                    Price = dto.Price,
                };
                _repository.AddBass(bass);
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

        public async Task <List<BassGuitar>> DeleteBassGuitar(DeleteBassGuitarDto dto)
        {
            if(_repository.IsExistGuitar(dto.BassId) == null) 
            {
                throw new Exception("Not Found");
            }
             return _repository.DeleteBassGuitar(_repository.IsExistGuitar(dto.BassId));
        }

        public async Task< List<BassGuitar>> GetAllBassGuitars()
        {
            return _repository.GetAllBassGuitar();
        }

        public async Task UpdateBassGuitar(UpdateBassGuitarPriceDto dto)
        {
            if (_repository.IsExistGuitar(dto.BassId) == null)
            {
                throw new Exception("Not Found");
            }
            _repository.UpdateBassPrice(_repository.IsExistGuitar(dto.BassId), dto.BassPrice);
            await _unitOfWork.Complete();
        }
    }
}
