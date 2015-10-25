using System;
using System.Collections.Generic;
using ProductApplication.Models.Entities;
using ProductApplication.Models.Repositories;

namespace ProductApplication.Models.Services
{
    public class ProductService
    {
        private ProductsRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductsRepository();
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                var products = _productRepository.GetProducts();
                return products;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}