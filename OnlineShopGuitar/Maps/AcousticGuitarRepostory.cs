using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class AcousticGuitarRepostory : IAcousticGuitarRepostory
    {
        private readonly EfDbContext _context;
        public AcousticGuitarRepostory(EfDbContext context)
        {
            _context = new EfDbContext();
        }

        public void AddAcoustic(AcousticGuitar acoustic)
        {
            _context.AcousticGuitars.Add(acoustic);
            _context.SaveChanges();
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
    }
}
