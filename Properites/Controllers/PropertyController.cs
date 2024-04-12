using Microsoft.AspNetCore.Mvc;
using Properites.Helpers;
using Properites.Models;
using System.Diagnostics;
using System.Linq;

namespace Properites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index", PropertySource.Properties);
        }

        public IActionResult Details(int id)
        {
            var property = PropertySource.Properties.FirstOrDefault(p => p.ID == id);
            if (property == null)
            {
                return NotFound();
            }
            return View(property);
        }


      public IActionResult Add()
{
    return RedirectToAction("Login", "Account");
}



        [HttpPost]
        public IActionResult Add(Property property)
        {
            
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
