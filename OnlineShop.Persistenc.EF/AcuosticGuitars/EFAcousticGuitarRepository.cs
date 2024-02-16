using OnlineShop.Entities;
using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFAcousticGuitarRepository : AcousticGuitarRepository
    {
        private readonly EfDbContext _context;
        public EFAcousticGuitarRepository(EfDbContext context)
        {
            _context = context;
        }

        public void AddAcoustic(AcousticGuitar acoustic)
        {
         
            _context.AcousticGuitars.Add(acoustic);
           
        }
        public void AddGuitar(Guitar guitar)
        {
            _context.Guitars.Add(guitar);
        }

        public List<AcousticGuitar> GetAllAcoustic()
        {
           return _context.AcousticGuitars.ToList();
        }


        public List<AcousticGuitar> DeleteAcoustic(AcousticGuitar acoustic)
        {
         
            _context.AcousticGuitars.Remove(acoustic);
            _context.SaveChanges();
            return _context.AcousticGuitars.ToList();
          
        }

        public void UpadateAcoustic(AcousticGuitar acousticGuitar,decimal price)
        {
            //var acoustic=_context.AcousticGuitars.FirstOrDefault(_=>_.Id == id);
            //if (acoustic == null)
            //{
            //    throw new Exception("not Found");
            //}
            acousticGuitar.Price = price;
            
        }


        AcousticGuitar AcousticGuitarRepository.IsExistGuitar(int id)
        {
            return _context.AcousticGuitars.FirstOrDefault(_ => _.Id == id);
        }
    }
}
