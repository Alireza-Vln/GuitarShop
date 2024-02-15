﻿using Cantracts;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class ElectricGuitarAppService : ElectricGuitarService
    {
        private readonly ElectriceGuitarRepostory _electriceRepostory;
        private readonly UnitOfWork _unitOfWork;
        public ElectricGuitarAppService(ElectriceGuitarRepostory electriceGuitar,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _electriceRepostory = electriceGuitar;
        }
        public async Task AddElectric(AddElecetricGuitarDto dto)
        {
            var electric = new ElectircGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,
            };
            _electriceRepostory.AddElectric(electric);
            await _unitOfWork.Complete();
        }

        public async Task<List<ElectircGuitar>> DeleteElectircGuitars(DeleteElectricGuitarDto dto)
        {
            return _electriceRepostory.DeleteElectircGuitars(dto.ElectricId);
            
        }

        public async Task<List<ElectircGuitar>> GetElectircGuitars()
        {
            return _electriceRepostory.GetElectric();
        }

    
        public async Task UpdateElectircGuitar(UpdateElectricGuitarDto dto)
        {
            _electriceRepostory.UpadateElectricGuitarPrice(dto.ElectricId, dto.ElectricePrice);
            await _unitOfWork.Complete();

        }
    }
}
