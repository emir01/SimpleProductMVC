using ProductApplication.Models.Entities;

namespace ProductApplication.ViewModels.Mappings
{
    public static class ProductMappings
    {
        public static Product FromEditProductViewModel(ProductEditViewModel viewModel)
        {
            return new Product()
            {
                Id = viewModel.Id ?? 0,
                Quantity = viewModel.Quantity,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price,
                Category = viewModel.Category
            };
        }

        public static ProductEditViewModel FromProduct(Product createdProduct)
        {
            return new ProductEditViewModel()
            {
                Id = createdProduct.Id,
                Name = createdProduct.Name,
                Description = createdProduct.Description,
                Quantity = createdProduct.Quantity,
                Price = createdProduct.Price,
                Category = createdProduct.Category
            };
        }
    }
}