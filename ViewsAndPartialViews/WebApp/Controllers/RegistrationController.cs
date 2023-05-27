using Microsoft.AspNetCore.Mvc;
using WebApp.Helpers.Services;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers;

public class RegistrationController : Controller
{
    private readonly AuthService _authService;

    public RegistrationController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        ViewData["Title"] = "Registration";
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserRegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (await _authService.UserAldredyExistsAsync(model))
                ModelState.AddModelError("", "This email appear to be registred already..");

            if (await _authService.RegisterUserAsync(model))
                return RedirectToAction("Index", "Login");



        }
        return View(model);
    }
}
