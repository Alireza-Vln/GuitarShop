﻿using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Maps;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Services
{
    public class BassGuitarService : IBassGuitarService
    {
        private readonly IBassGuitarRepostory _bassGuitarRepostory;

        public BassGuitarService(IBassGuitarRepostory bassGuitarRepostory)
        {
            _bassGuitarRepostory = bassGuitarRepostory;
        }

        public void AddBass(AddGuitarBassDto dto)
        {
            var bass = new BassGuitar
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Count = dto.Count,
                Price = dto.Price,
            };

         _bassGuitarRepostory.AddBass(bass);
           
        }
    }
}