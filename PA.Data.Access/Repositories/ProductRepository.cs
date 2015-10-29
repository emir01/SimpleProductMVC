using System.Linq;
using PA.Core.DataModel.Context;
using PA.Core.DataModel.Entities;
using PA.Data.Interfaces;

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
