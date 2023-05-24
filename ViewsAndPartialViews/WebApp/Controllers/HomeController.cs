using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Contexts;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers;


public class HomeController : Controller
{
    private readonly IdentityContext _context;

    public HomeController(IdentityContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";

        var newProducts = _context.Products.Include(p => p.Categories)
                                            .Where(p => p.Categories.Any(c => c.CategoryId == 1))
                                            .ToList();

        var popularProducts = _context.Products.Include(p => p.Categories)
                                               .Where(p => p.Categories.Any(c => c.CategoryId == 2))
                                               .ToList();

        var featuredProducts = _context.Products.Include(p => p.Categories)
                                                .Where(p => p.Categories.Any(c => c.CategoryId == 3))
                                                .ToList();

        var viewModel = new HomeViewModel
        {
            NewProducts = newProducts,
            PopularProducts = popularProducts,
            FeaturedProducts = featuredProducts
        };

        return View(viewModel);
    }

}
