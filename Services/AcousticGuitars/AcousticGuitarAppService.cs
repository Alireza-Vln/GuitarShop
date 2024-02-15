using Cantracts;
using OnlineShop.Entities;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class AcousticGuitarAppService : AcousticGuitarService
    {
        private readonly AcousticGuitarRepository _repository;
        private readonly UnitOfWork _unitOfWork;
        public AcousticGuitarAppService(AcousticGuitarRepository repostory,UnitOfWork unitOfWork)
        {

            _repository = repostory;
            _unitOfWork = unitOfWork;
        }
        public async Task AddAcoustic(AddAcousticGuitarDto dto)
        {

            var acoustic = new AcousticGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,  
            };
            
            _repository.AddAcoustic(acoustic);
           await _unitOfWork.Complete();
        }

        public async Task <List<AcousticGuitar>> DeleteAcoustic(DeleteAcousticGuitarDto dto)
        {
            if(_repository.IsExistGuitar(dto.AcousticId)==null)
            {
                throw new Exception("Not Found");
            }

          return _repository.DeleteAcoustic(_repository.IsExistGuitar(dto.AcousticId));
           //await _unitOfWork.Complete();
           
        }

        public async Task<List<AcousticGuitar>> GetAllAcousticGuitars()
        {
            return _repository.GetAllAcoustic();
        }

        public async Task UpdateAcousticGuitar(UpdateAcousticGuitarDto dto)
        {
            if(_repository.IsExistGuitar(dto.AcousticId) == null)
            {
                throw new Exception("Not Found");
            }
            _repository.UpadateAcoustic
                (_repository.IsExistGuitar(dto.AcousticId)
                ,dto.AcousticPrice);

          await _unitOfWork.Complete();
        }
    }
}
