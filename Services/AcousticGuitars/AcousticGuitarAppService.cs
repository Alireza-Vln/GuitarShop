using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class AcousticGuitarAppService : AcousticGuitarService
    {
        private readonly AcousticGuitarRepostory _repostory;
        public AcousticGuitarAppService(AcousticGuitarRepostory repostory)
        {
            _repostory = repostory;
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
        }

        public async Task <List<AcousticGuitar>> DeleteAcoustic(DeleteAcousticGuitarDto dto)
        {
    
           return _repostory.DeleteAcoustic(dto.AcousticId);
           
        }

        public async Task<List<AcousticGuitar>> GetAllAcousticGuitars()
        {
            return _repostory.GetAllAcoustic();
        }

        public async Task UpdateAcousticGuitar(UpdateAcousticGuitarDto dto)
        {
            _repostory.UpadateAcoustic(dto.AcousticId,dto.AcousticPrice);
        }
    }
}
