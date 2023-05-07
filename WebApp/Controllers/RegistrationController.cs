using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Services;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers;

public class RegistrationController : Controller
{
    private readonly AuthServive _auth;

    public RegistrationController(AuthServive auth)
    {
        _auth = auth;
    }

    public IActionResult Index()
    {
        ViewData["Title"] = "Registration";
        return View();
    }

    [HttpPost]
    public async Task <IActionResult> Index(UserRegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (await _auth.RegAsync(model))

            return RedirectToAction("Index", "Login");

            ModelState.AddModelError("", "A user with the same email already exists");
        }

        return View(model);
    }
}
