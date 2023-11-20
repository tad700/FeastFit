using FeastFit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FeastFit.Controllers
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
            return View();
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public IActionResult WebIndex() 
        { 
            return View(); 
        }
=======
        public IActionResult WebIndex() { return View(); }
>>>>>>> 71dd9fe0105b47d58ab48f123d2ad3b1ee570985
=======
        public IActionResult WebIndex() { return View(); }
>>>>>>> 71dd9fe0105b47d58ab48f123d2ad3b1ee570985

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}