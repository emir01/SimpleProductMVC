using PA.Web.ViewModels.Product;

namespace PA.Web.ViewModels.Mappings
{
    public static class ProductMappings
    {
        public static Models.Entities.Product FromEditProductViewModel(ProductEditViewModel viewModel)
        {
            return new Models.Entities.Product()
            {
                Id = viewModel.Id ?? 0,
                Quantity = viewModel.Quantity,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price,
                Category = viewModel.Category
            };
        }

        public static ProductEditViewModel FromProduct(Models.Entities.Product createdProduct)
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