using Cantracts;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class BassGuitarAppService : BassGuitarService
    {
        private readonly BassGuitarRepostory _bassGuitarRepostory;
        private readonly UnitOfWork _unitOfWork;

        public BassGuitarAppService(BassGuitarRepostory bassGuitarRepostory,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _bassGuitarRepostory = bassGuitarRepostory;
        }

        public async Task AddBass(AddGuitarBassDto dto)
        {
            var bass = new BassGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,
            };

            _bassGuitarRepostory.AddBass(bass);
            await _unitOfWork.Complete();

        }

        public async Task <List<BassGuitar>> DeleteBassGuitar(DeleteBassGuitarDto dto)
        {
             return _bassGuitarRepostory.DeleteBassGuitar(dto.BassId);
        }

        public async Task< List<BassGuitar>> GetAllBassGuitars()
        {
            return _bassGuitarRepostory.GetAllBassGuitar();
        }

        public async Task UpdateBassGuitar(UpdateBassGuitarPriceDto dto)
        {
            _bassGuitarRepostory.UpdateBassPrice(dto.BassId, dto.BassPrice);
            await _unitOfWork.Complete();
        }
    }
}
