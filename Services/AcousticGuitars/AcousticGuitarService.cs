using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class AcousticGuitarService : IAcousticGuitarService
    {
        private readonly IAcousticGuitarRepostory _repostory;
        public AcousticGuitarService(IAcousticGuitarRepostory repostory)
        {
            _repostory = repostory;
        }
        public void AddAcoustic(AddAcousticGuitarDto dto)
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

        public List<AcousticGuitar> DeleteAcoustic(DeleteAcousticGuitarDto dto)
        {
    
           return _repostory.DeleteAcoustic(dto.AcousticId);
           
        }

        public List<AcousticGuitar> GetAllAcousticGuitars()
        {
            return _repostory.GetAllAcoustic();
        }

        public void UpdateAcousticGuitar(UpdateAcousticGuitarDto dto)
        {
            _repostory.UpadateAcoustic(dto.AcousticId,dto.AcousticPrice);
        }
    }
}
