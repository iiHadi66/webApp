using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Controllers;

public class ContactsController : Controller
{
    private readonly IdentityContext _context;

    public ContactsController(IdentityContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewData["Title"] = "Contact Us";

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(ContactEntity contact)
    {
        if (ModelState.IsValid)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction("Thanks");
        }
        return View(contact);
    }

    public IActionResult Thanks()
    {
        return View();
    }

}


