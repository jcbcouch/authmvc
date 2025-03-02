using authmvc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace authmvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            RegisterViewModel registerViewModel = new();
            return View(registerViewModel);
        }
    }
}
