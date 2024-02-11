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

        public List<ElectircGuitar> DeleteElectircGuitars(int Id)
        {
            var electric=_context.ElectricGuitars.FirstOrDefault(_=> _.Id == Id);
            _context.ElectricGuitars.Remove(electric);
            _context.SaveChanges();
            return _context.ElectricGuitars.ToList();
        }

        public List<ElectircGuitar> GetElectric()
        {
            return _context.ElectricGuitars.ToList();
        }

        public void UpadateElectricGuitarPrice(int Id, decimal Price)
        {
            var electric = _context.ElectricGuitars.First(_ => _.Id == Id);
            electric.Price = Price;
            _context.SaveChanges();
        }
       
    }
}
