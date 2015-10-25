using ProductApplication.Models.Entities;

namespace ProductApplication.Models.Utilities
{
    public static class ProductFactory
    {
        public static Product CreateProduct(int id, string name, string category, int price = 10, string description = "", int quantity = 1 )
        {
            return new Product
            {
                Id = id,
                Name = name,
                Category = category,
                Description = description,
                Quantity = quantity,
                Price = price
            };
        }
    }
}