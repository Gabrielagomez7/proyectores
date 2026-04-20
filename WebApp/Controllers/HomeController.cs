using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            //uso  de viewBag
            ViewBag.Id = "1";
            ViewBag.Marca = "Epson";
            ViewBag.Modelo = "XLight";
            ViewBag.NumeroDeSerie = "123456";
            ViewBag.Situacion = "Bueno";
            ViewBag.FechaDeAlta = DateTime.Now.ToString("f");
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
