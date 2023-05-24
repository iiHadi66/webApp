using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Contexts;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IdentityContext _context;

        public ProductsController(IdentityContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Products";
            var allProducts = _context.Products.ToList();

            ViewBag.AllProducts = allProducts;
            return View();
        }

        public IActionResult ProductDetails(int id) 
        {

            // Find the product by id in the database
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            // Pass the product to the view
            
            return View(product);
        }


    }
}
