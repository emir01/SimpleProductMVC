using System.Web.Mvc;
using PA.Business.Interfaces;
using PA.Web.Infrastructure;
using PA.Web.ViewModels.ProductViewModels;

namespace PA.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [TitleActionFilter("Product Page")]
        public ActionResult Index()
        {
            var productsResult = _productService.GetProducts();
            
            return View(productsResult);
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
            return Content("ok");
        }
    }
}