using KatiSiviGazWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KatiSiviGazWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(KatiSiviGaz katiSiviGaz)
        {
            var derece_ = katiSiviGaz.SicaklikDerecesi;
            var message = string.Empty;

            if (derece_ < 0) 
            {
                message = "0 derecenin altında olduğundan katı halde";                
            }
            else if (0 < derece_ && derece_ < 100)
            {
                message= "0 - 100 derece arasında olduğundan sıvı halde";
            }
            else
            {
                message= "100 dereceden fazla olduğundan gaz halde";
            }
            ViewBag.Message = message;
            return View("katiSiviGaz");
        }

        public IActionResult Privacy()
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