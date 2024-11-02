using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository( ApplicationDbContext db ) : base( db )
        {
            _db = db;
        }


        public void Save()
        {
            _db.SaveChanges();
        }
        public void Update( Product obj )
        {
            var objFromDb = _db.Products.FirstOrDefault( u => u.Id == obj.Id );
            if (objFromDb != null)
            { 
                objFromDb.Title = obj.Title;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Author = obj.Author;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImageUrl != null)
                { 
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
