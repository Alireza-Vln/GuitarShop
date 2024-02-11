﻿using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class ClassicGuitarRepostory : IClassicGuitarRepostory
    {
        private readonly EfDbContext _Context;
        public ClassicGuitarRepostory(EfDbContext context)
        {
            _Context = context;
        }

        public void AddClassic(ClassicGuitar classicGuitar)
        {
           _Context.ClassicGuitars.Add(classicGuitar);
            _Context.SaveChanges();
        }

        public List<ClassicGuitar> DeleteClassicGuitars(int id)
        {
            var classic = _Context.ClassicGuitars.FirstOrDefault(_=>_.Id == id);
            _Context.ClassicGuitars.Remove(classic);
            _Context.SaveChanges();
            return _Context.ClassicGuitars.ToList();
        }

        public List<ClassicGuitar> GetClassicGuitars()
        {
          return _Context.ClassicGuitars.ToList();
        }

        public void UpdateClassicGuitar(int id, decimal price)
        {
            var classic = _Context.ClassicGuitars.FirstOrDefault(_ => _.Id == id);
            if(classic == null)
            {
                throw new Exception("not Found");
            }
            classic.Price = price;  
            _Context.SaveChanges();
        }
    }
}
