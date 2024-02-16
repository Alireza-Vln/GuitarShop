using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFElectricGuitarRepository:ElectriceGuitarRepository
    {
        private readonly EfDbContext _context;

        public EFElectricGuitarRepository(EfDbContext context)
        {
            _context = context;
        }

        public void AddElectric(ElectricGuitar electircGuitar)
        {
            _context.ElectricGuitars.Add(electircGuitar);
            
        }



        public List<ElectricGuitar> DeleteElectircGuitars(ElectricGuitar electircGuitar)
        {
           _context.ElectricGuitars.Remove(electircGuitar);
            _context.SaveChanges();
            return _context.ElectricGuitars.ToList();
        }

        public List<ElectricGuitar> GetElectric()
        {
            return _context.ElectricGuitars.ToList();
        }

     
 

        public void UpadateElectricGuitarPrice(ElectricGuitar electircGuitar, decimal Price)
        {
           electircGuitar.Price = Price;
        }


        public ElectricGuitar ISExistGuitar(int id)
        {
            return _context.ElectricGuitars.FirstOrDefault(_ => _.Id == id);
        }

        public void AddGuitar(Guitar guitar)
        {
           _context.Guitars.Add(guitar);
        }
    }
}
