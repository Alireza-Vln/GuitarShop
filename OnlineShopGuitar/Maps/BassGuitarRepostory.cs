using OnlineShopGuitar.Entities;

namespace OnlineShopGuitar.Maps
{
    public class BassGuitarRepostory : IBassGuitarRepostory
    {
        private readonly EfDbContext _dbContext;
        public BassGuitarRepostory(EfDbContext context) 
        {
            _dbContext = context;
        }
        public void AddBass(BassGuitar bassGuitar)
        {
          _dbContext.BassGuitars.Add(bassGuitar);
            _dbContext.SaveChanges();
        }
    }
}
