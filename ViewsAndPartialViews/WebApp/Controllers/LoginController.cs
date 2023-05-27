using Microsoft.AspNetCore.Mvc;
using WebApp.Helpers.Services;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers;

public class LoginController : Controller
{

    private readonly AuthService _authService;

    public LoginController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    public IActionResult Index(string ReturnUrl = null!)
    {
        var model = new UserLoginViewModel();
        if (ReturnUrl != null)
            model.ReturnUrl = ReturnUrl;

        return View(model);
    }


    [HttpPost]
    public async Task<IActionResult> Index(UserLoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (await _authService.LoginAsync(model))
                return LocalRedirect(model.ReturnUrl);

            ModelState.AddModelError("", "Invalid credentials..please try again");
        }

        return View(model);
    }


}
