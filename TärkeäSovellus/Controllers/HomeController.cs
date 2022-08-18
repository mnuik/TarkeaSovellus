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

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NikoAction()
        {
            ViewBag.Polku = "Tultiin NikoActionin kautta tännä";
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Tämä lisäys HomeController.cs -tiedostoon
        public IActionResult AhtiAction()
        {
            ViewBag.Polku = "Tultiin AhtiActionin kautta tännä";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}