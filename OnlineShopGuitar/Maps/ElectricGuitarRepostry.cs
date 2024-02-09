using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class ElectricGuitarRepostry:IElectriceGuitarRepostory
    {
        private readonly EfDbContext _context;

        public ElectricGuitarRepostry(EfDbContext context)
        {
            _context = context;
        }

        public void AddElectric(ElectircGuitar electircGuitar)
        {
            _context.ElectricGuitars.Add(electircGuitar);
            _context.SaveChanges();
        }
    }
}
