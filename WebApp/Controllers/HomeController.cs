using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData
            ViewData["Id"] = "1";
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "Ecotank";
            ViewData["Número de serie"] = "382901";
            ViewData["Situación"] = "Bueno";
            ViewData["FechaDeAlta"] = DateTime.Now.ToString("d"); ;
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
