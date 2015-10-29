using System.Linq;
using PA.DataModel.Entities;

namespace PA.Data.Interfaces
{
    /// <summary>
    /// Very simple interface describing the product repository
    /// </summary>
    public interface IProductRepository
    {
        IQueryable<Product> QueryProducts();

        Product GetProduct(int id);
    }
}
