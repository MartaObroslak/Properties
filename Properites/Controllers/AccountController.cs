using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class AccountController : Controller
    {
  
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return RedirectToAction("Login");
        }

    
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string password, string confirmPassword)
        {
            
            return RedirectToAction("Register");
        }
    }
}
