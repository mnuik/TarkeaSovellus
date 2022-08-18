using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TärkeäSovellus.Models;

namespace TärkeäSovellus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //Tämä lisäys HomeController.cs -tiedostoon
        public IActionResult AhtiAction()
        {
            ViewBag.Polku = "Tultiin AhtiActionin kautta tännä";
            return View("Index");
        }

        //kaarlen

        public IActionResult Index()
        {
            return View();
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