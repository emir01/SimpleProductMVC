using System.Collections.Generic;
using PA.Core.DataModel.Entities;
using PA.Core.Infrastructure.ResultObjects;

namespace PA.Business.Interfaces
{
    public interface IProductService
    {
        DataResult<List<Product>> GetProducts();
    }
}
