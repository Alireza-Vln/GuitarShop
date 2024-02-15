using Cantracts;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class AcousticGuitarAppService : AcousticGuitarService
    {
        private readonly AcousticGuitarRepostory _repostory;
        private readonly UnitOfWork _unitOfWork;
        public AcousticGuitarAppService(AcousticGuitarRepostory repostory,UnitOfWork unitOfWork)
        {

            _repostory = repostory;
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
            _repostory.AddAcoustic(acoustic);
           await _unitOfWork.Complete();
        }

        public async Task <List<AcousticGuitar>> DeleteAcoustic(DeleteAcousticGuitarDto dto)
        {
    
           return _repostory.DeleteAcoustic(dto.AcousticId);
           //await _unitOfWork.Complete();
           
        }

        public async Task<List<AcousticGuitar>> GetAllAcousticGuitars()
        {
            return _repostory.GetAllAcoustic();
        }

        public async Task UpdateAcousticGuitar(UpdateAcousticGuitarDto dto)
        {
            _repostory.UpadateAcoustic(dto.AcousticId,dto.AcousticPrice);
          await _unitOfWork.Complete();
        }
    }
}
