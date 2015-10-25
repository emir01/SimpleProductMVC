using System;
using System.Collections.Generic;
using System.Linq;
using ProductApplication.Models.Entities;
using ProductApplication.Models.Utilities;

namespace ProductApplication.Models.Repositories
{
    public class ProductsRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            ProductFactory.CreateProduct(1, "Dell M2442", "Monitor"),
            ProductFactory.CreateProduct(2, "Genius Keyboard K107", "Keyboard"),
            ProductFactory.CreateProduct(3, "Logitech MX510", "Mouse")
        };
        
        /// <summary>
        /// Return the in memory list of products that acts as a table in the database
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return _products;
        }

        /// <summary>
        /// Return a single product for the given id. If a product does not exist
        /// for the given id returns null.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        /// <summary>
        /// Create a product and store it in the in memory list of products.
        /// 
        /// The product is asigned an auto-generated id based on the current ids of the products in the list
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public Product CreateProduct(Product product)
        {
            // fake a database and autogenerate the id based
            // on the current ids for the products
            var id = _products.Max(p => p.Id) + 1;
            product.Id = id;

            _products.Add(product);

            return product;
        }

        /// <summary>
        /// Update the product in the database (the in memory list) with the given product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public Product UpdateProduct(Product product)
        {
            // if the id of the product is not set (defaults to 0 because value type)
            if (product.Id == 0)
            {
                throw new Exception();
            }

            var productToUpdate = GetProductById(product.Id);

            if (productToUpdate == null)
            {
                throw new Exception(string.Format("There is no product with the given id: ", product.Id));
            }

            var updatedProduct = UpdateProductProperties(productToUpdate, product);

            return updatedProduct;
        }

        #region Helpers

        private Product UpdateProductProperties(Product productInDatabase, Product productFromClient)
        {
            // update the properties for the product in the database with the propertiy values
            // from the product form the client. Don't touch the id property
            var updatedProduct = SetPropertyList(productInDatabase, productFromClient, "Id");
            return updatedProduct;
        }

        private T SetPropertyList<T>(T destination, T source, params string[] excludedProperties)
        {

            var properties = typeof(T).GetProperties();

            foreach (var propertyInfo in properties)
            {
                // do not do anything if the property is in the exclude list
                if (excludedProperties != null && excludedProperties.Contains(propertyInfo.Name))
                {
                    continue;
                }

                // get the value of the property from the source
                var sourceValue = propertyInfo.GetValue(source);
                propertyInfo.SetValue(destination, sourceValue);
            }

            return destination;
        }

        #endregion
    }
}