using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class EFBassGuitarRepository : BassGuitarRepository
    {
        private readonly EfDbContext _dbContext;
        public EFBassGuitarRepository(EfDbContext context) 
        {
            _dbContext = context;
        }
        public void AddBass(BassGuitar bassGuitar)
        {
          _dbContext.BassGuitars.Add(bassGuitar);
            
        }

        public List<BassGuitar> DeleteBassGuitar(BassGuitar bassGuitar)
        {
             _dbContext.Remove(bassGuitar);
            _dbContext.SaveChanges();
            return _dbContext.BassGuitars.ToList();
        }

        public List<BassGuitar> GetAllBassGuitar()
        {
            return _dbContext.BassGuitars.ToList();
        }

      
        public void UpdateBassPrice(BassGuitar bassGuitar, decimal price)
        {
           bassGuitar.Price = price;    
         
        }
        public BassGuitar IsExistGuitar(int id)
        {
            return _dbContext.BassGuitars.FirstOrDefault(_ => _.Id == id);
        }
    }
}
