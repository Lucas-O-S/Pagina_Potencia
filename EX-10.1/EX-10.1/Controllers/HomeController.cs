using EX_10._1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EX_10._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        public IActionResult CalcularPotencia(int numero, int potencia)
        {

            ViewBag.Numero = numero;
            ViewBag.Potencia = potencia;

            float resultado = numero;
            for (int i = 1; i< potencia; i++)
            {
                resultado *= numero;
            }
            return View("index", resultado);

        }
    }
}
