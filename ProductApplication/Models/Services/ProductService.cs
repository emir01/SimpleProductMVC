using System;
using System.Collections.Generic;
using PA.Web.Models.Entities;
using PA.Web.Models.Repositories;

namespace PA.Web.Models.Services
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

        public Product Create(Product productEntity)
        {
            try
            {
                var createdProduct = _productRepository.CreateProduct(productEntity);
                return createdProduct;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}