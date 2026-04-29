using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {

            var modelo = LoadData();
            return View(modelo);
        }


        private IEnumerable<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "963454",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 2,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "122296",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "267456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "122056",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now

            });

            return proyectores; 
        }

        public IActionResult Create()
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
