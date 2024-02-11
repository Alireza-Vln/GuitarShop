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

        public List<BassGuitar> DeleteBassGuitar(int id)
        {
            var bass=_dbContext.BassGuitars.Where(_ => _.Id == id).First();
            _dbContext.BassGuitars.Remove(bass);
            _dbContext.SaveChanges() ;
            return _dbContext.BassGuitars.ToList();
        }

        public List<BassGuitar> GetAllBassGuitar()
        {
            return _dbContext.BassGuitars.ToList();
        }

        public void UpdateBassPrice(int id, decimal price)
        {
            var bass=_dbContext.BassGuitars.First(x => x.Id == id);
            if (bass == null)
            {
                throw new Exception("not Find");
            }
          bass.Price = price;

            _dbContext.SaveChanges();

        }
    }
}
