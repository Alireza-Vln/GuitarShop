using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class ElectricGuitarService : IElectricGuitarService
    {
        private readonly IElectriceGuitarRepostory _electriceRepostory;
        public ElectricGuitarService(IElectriceGuitarRepostory electriceGuitar)
        {
            _electriceRepostory = electriceGuitar;
        }
        public void AddElectric(AddElecetricGuitarDto dto)
        {
            var electric = new ElectircGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,
            };
            _electriceRepostory.AddElectric(electric);
        }
    }
}
