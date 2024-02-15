using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFAcousticGuitarRepostory : AcousticGuitarRepostory
    {
        private readonly EfDbContext _context;
        public EFAcousticGuitarRepostory(EfDbContext context)
        {
            _context = context;
        }

        public void AddAcoustic(AcousticGuitar acoustic)
        {
            _context.AcousticGuitars.Add(acoustic);
           
        }

        public List<AcousticGuitar> GetAllAcoustic()
        {
           return _context.AcousticGuitars.ToList();
        }
        public List<AcousticGuitar> DeleteAcoustic(int Id)
        {
            var acoustic= _context.AcousticGuitars.Where(_=>_.Id == Id).First();
            _context.AcousticGuitars.Remove(acoustic);
            _context.SaveChanges();
            return _context.AcousticGuitars.ToList();
          
        }

        public void UpadateAcoustic(int id, decimal price)
        {
            var acoustic=_context.AcousticGuitars.FirstOrDefault(_=>_.Id == id);
            if (acoustic == null)
            {
                throw new Exception("not Found");
            }
            acoustic.Price = price;
            
        }
    }
}
