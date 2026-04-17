using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class Proyectores : Controller
    {
        public string Index()
        {
            return "Aquí se mostrará la lista de proyectores registrados";
        }


        public IActionResult Details(int id)
        {
            string html = $"<h1>Nuevo proyector</h1>Aqu&iacute; se mostrar&aacute; la informaci&oacute; detallada del proyector con el ID: <strong>{id}</strong>";

            return Content(html, "text/html");

        }

        public IActionResult Delete(int id)
        {
            string html = $"<h1>Dar De Baja</h1>Aquí se darmostrar&aacute; de baja el proyector <strong>#{id}</strong>";
            return Content(html, "text/html");
        }

        public IActionResult Edit(int id)
        {
            string html = $"Aquí se modificará la información de un proyector específico con el ID: <strong>{id}</strong>";
            return Content(html, "text/html");
        }
    }
}
   