using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFClassicGuitarRepository : ClassicGuitarRepository
    {
        private readonly EfDbContext _Context;
        public EFClassicGuitarRepository(EfDbContext context)
        {
            _Context = context;
        }

        public void AddClassic(ClassicGuitar classicGuitar)
        {
           _Context.ClassicGuitars.Add(classicGuitar);
          
        }

        public List<ClassicGuitar> DeleteClassicGuitars(ClassicGuitar classicGuitar)
        {
           
            _Context.ClassicGuitars.Remove(classicGuitar);
            _Context.SaveChanges();
            return _Context.ClassicGuitars.ToList();
        }

        public List<ClassicGuitar> GetClassicGuitars()
        {
          return _Context.ClassicGuitars.ToList();
        }
        public void UpdateClassicGuitar(ClassicGuitar classicGuitar, decimal price)
        {
      
          classicGuitar.Price = price;  
           
        }
        public ClassicGuitar IsExistGuitar(int id)
        {
            return _Context.ClassicGuitars.FirstOrDefault(_ => _.Id == id);
        }

        public void AddGuitar(Guitar guitar)
        {
          _Context.Guitars.Add(guitar);
        }
    }
}
