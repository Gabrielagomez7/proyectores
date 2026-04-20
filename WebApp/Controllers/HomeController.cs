using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            //uso  de viewData
            ViewData["Id"] = "2";
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "Xlight";
            ViewData["NumeroDeSerie"] = "123456";
            ViewData["Situacion"] = "Bueno";
            ViewData["FechaDeAlta"] = DateTime.Now.ToString("f");
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
