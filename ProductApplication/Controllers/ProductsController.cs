using System.Web.Configuration;
using System.Web.Mvc;
using ProductApplication.Models.Services;
using ProductApplication.ViewModels;
using ProductApplication.ViewModels.Mappings;

namespace ProductApplication.Controllers
{
    public class ProductsController : Controller
    {
        private ProductService _productService;

        public ProductsController()
        {
            _productService = new ProductService();
        }

        // GET: Products
        public ActionResult Index()
        {
            ViewBag.Title = "Products Page";

            var products = _productService.GetAllProducts();

            return View(products);
        }
        
        // GET: /Products/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new ProductEditViewModel());
        }

        // POST: /Products/Create
        [HttpPost]
        public ActionResult Create(ProductEditViewModel product)
        {
            var productEntity = ProductMappings.FromEditProductViewModel(product);

            var createdProduct = _productService.Create(productEntity);

            var createdViewModel = ProductMappings.FromProduct(createdProduct);

            return View(createdViewModel);
        }
    }
}