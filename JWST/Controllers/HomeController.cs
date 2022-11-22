using JWST.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //Pag. de login
        {
            return View();
        }
        public IActionResult Registrarse()
        {
            return View();
        }

        public IActionResult Galeria()
        {
            return View();
        }

        public IActionResult Quees()
        {
            return View();
        }

        public IActionResult Quienfue()
        {
            return View();
        }

        public IActionResult Espejos()
        {
            return View();
        }

        public IActionResult Electronica()
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