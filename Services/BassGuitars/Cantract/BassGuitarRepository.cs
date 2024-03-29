﻿using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface BassGuitarRepository
    {
        public BassGuitar IsExistGuitar(int id);
        void AddBass(BassGuitar bassGuitar);
        void AddGuitar(Guitar guitar);
        List<BassGuitar> GetAllBassGuitar();
        List<BassGuitar> DeleteBassGuitar(BassGuitar bassGuitar);
        void UpdateBassPrice(BassGuitar bassGuitar,decimal price);
       
        
    }
}
