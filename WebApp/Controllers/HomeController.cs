using Microsoft.AspNetCore.Mvc;
using proyectores_.Models;
using System.Diagnostics;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        { 
            //uso  del modelo de modelos de la vista

            var proyector = new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
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
