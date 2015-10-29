using System.Linq;
using System.Web.Mvc;
using PA.Data.Interfaces;
using PA.Web.ViewModels.ProductViewModels;

namespace PA.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Products
        public ActionResult Index()
        {
            ViewBag.Title = "Products Page";

            var products = _productRepository.QueryProducts().ToList();

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
            return Content("ok");
        }
    }
}