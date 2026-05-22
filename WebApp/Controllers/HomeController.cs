using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Modelo de la vista
            Proyector proyector = new()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "Ecotank",
                NumeroDeSerie = "382901",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            };
            return View(proyector);
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
