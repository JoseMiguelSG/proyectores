using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()
        {
            return Content(
                "<p>Aqu&iacute se mostrara la lista de proyectores registrados</p>",
                "text/html"
                );
        }
        public IActionResult Details(int id)
        {
            string cadena = "<h1> Nuevo proyector </h1>";
            cadena += $"<p> Aqu&iacute se mostrara la informacion del proyector especifico: {id} </p>";
            return Content(cadena, "text/html");
        }

        public IActionResult Delete(int id)
        {
            string cadena = $"<h1> Dar de baja </h1>" +
                $"<p> Aqui se dara de baja el proyector: {id} </p>";
            return Content(cadena, "text/html");
        }

        public IActionResult Edit(int id)
        {
            string cadena = $"<h1> Editar proyector </h1>" +
                $"<p> Aqui se modificara el proyector: {id} </p>";
            return Content(cadena, "text/html");
        }


    }
}
