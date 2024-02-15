using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFElectricGuitarRepostry:ElectriceGuitarRepostory
    {
        private readonly EfDbContext _context;

        public EFElectricGuitarRepostry(EfDbContext context)
        {
            _context = context;
        }

        public void AddElectric(ElectircGuitar electircGuitar)
        {
            _context.ElectricGuitars.Add(electircGuitar);
            
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
            
        }
       
    }
}
