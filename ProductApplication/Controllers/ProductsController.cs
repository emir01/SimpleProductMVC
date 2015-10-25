using System.Web.Mvc;
using ProductApplication.Models.Services;

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
    }
}