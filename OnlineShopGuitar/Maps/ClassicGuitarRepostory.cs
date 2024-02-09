using OnlineShopGuitar.Entities;

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
    }
}
