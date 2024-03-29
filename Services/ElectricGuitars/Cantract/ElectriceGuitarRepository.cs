﻿using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public interface ElectriceGuitarRepository
    {
        public ElectricGuitar ISExistGuitar(int id);
        void AddElectric(ElectricGuitar electircGuitar);
        void AddGuitar(Guitar guitar);
        List <ElectricGuitar> GetElectric();
        List <ElectricGuitar> DeleteElectircGuitars(ElectricGuitar electricGuitar);
        void UpadateElectricGuitarPrice(ElectricGuitar electricGuitar,decimal Price);
    }
}
