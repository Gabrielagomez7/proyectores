using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {

        public IActionResult Index()
        {
            string html = "<h2>Inicio </h2>";
            html += $"<p>Aqu&iacute se mostrar&aacute la lista de proyectores registrados</p>";
            return Content(html, "text/html");
        }

        public IActionResult Details(int id)
        {
            return Content
                (
                "<h2>Nuevo Proyector </h2>"
                + $"<p>Aqu&iacute se mostrar&aacute la informaci&oacuten de un proyector {id}<p>",
                "text/html"
                );
        }


        public IActionResult Delete(int id)
        {
            return Content
                (
                "<h2>Dar de baja</h2>"
                + $"<p>Se dar&aacute de baja el proyector {id}</p>",
                "text/html"
                );
        }
    }
}