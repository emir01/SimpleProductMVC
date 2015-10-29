using System.Linq;
using PA.Data.Interfaces;
using PA.DataModel.Context;
using PA.DataModel.Entities;

namespace PA.Data.Access.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopContext _shopContext;
        
        public ProductRepository()
        {
            _shopContext = new ShopContext();
        }
        
        public IQueryable<Product> QueryProducts()
        {
            return _shopContext.Products;
        }
        
        public Product GetProduct(int id)
        {
            return _shopContext.Products.Find(id);
        }
    }
}
