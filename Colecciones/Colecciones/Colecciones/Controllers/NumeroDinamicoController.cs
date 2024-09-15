using Colecciones.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Colecciones.Controllers
{
    public class NumeroDinamicoController : Controller
    {
        
        //private static List<Dato> numeros = new List<Dato>();
        private static ArrayList numeros = new ArrayList();
        public IActionResult Index()
        {
            ViewBag.Numeros = numeros;
            return View();
        }
        [HttpPost]
        public IActionResult CapturarNumero(int numero) { 
            var numerodigitado = new Dato { Numero = numero };
            numeros.Add(numerodigitado);
            return RedirectToAction("Index");
        }
    }
}
