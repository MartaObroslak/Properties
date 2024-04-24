using Microsoft.AspNetCore.Mvc;
using Properites.Helpers;
using Properites.Models;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Properites.Controllers
{
    [Authorize] 
    public class PropertiesController : Controller
    {
        private readonly ILogger<PropertiesController> _logger;
        private readonly PropertiesContext _db;

        public PropertiesController(ILogger<PropertiesController> logger, PropertiesContext db)
        {
            _logger = logger;
            _db = db;
        }

        [AllowAnonymous] 
        public IActionResult Index()
        {
            var properties = _db.Properties.ToList();
            return View("Index", properties);
        }

        [AllowAnonymous] 
        public IActionResult Details(int id)
        {
            var property = _db.Properties.FirstOrDefault(p => p.ID == id);
            if (property == null)
            {
                return NotFound();
            }
            return View(property);
        }

     
        public IActionResult Add()
        {
            return View(new Property());
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Add(Property property)
        {
            if (ModelState.IsValid)
            {
                _db.Properties.Add(property);
                await _db.SaveChangesAsync(); 
                return RedirectToAction(nameof(Index)); 
            }
            return View(property);
        }

        [AllowAnonymous] 
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous] 
        public IActionResult About()
        {
            return View();
        }

        [AllowAnonymous] 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
