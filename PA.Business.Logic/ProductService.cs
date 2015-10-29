using System;
using System.Collections.Generic;
using System.Linq;
using PA.Business.Interfaces;
using PA.Core.DataModel.Entities;
using PA.Core.Infrastructure.ResultObjects;
using PA.Data.Interfaces;

namespace PA.Business.Logic
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public DataResult<List<Product>> GetProducts()
        {
            try
            {
                var products = _productRepository.QueryProducts().ToList();

                return new DataResult<List<Product>>
                {
                    Data = products,
                    IsSuccess = true,
                    Message = "Retrieved Products"
                };
            }
            catch (Exception ex)
            {
                return new DataResult<List<Product>>
                {
                    Message = ex.Message,
                    IsSuccess = false,
                    Data = null
                };
            }
        }
    }
}
