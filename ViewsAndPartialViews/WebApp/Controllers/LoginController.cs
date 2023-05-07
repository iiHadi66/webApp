using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers;

public class LoginController : Controller
{

    public IActionResult Index()
    {
       
        return View();
    }

  
}
