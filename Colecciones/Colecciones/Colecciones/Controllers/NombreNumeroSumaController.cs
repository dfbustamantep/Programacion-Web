using Colecciones.Models;
using Microsoft.AspNetCore.Mvc;

namespace Colecciones.Controllers
{
    public class NombreNumeroSumaController : Controller
    {
        private static List<Datos> informacion = new List<Datos>();

        public IActionResult NombresNumeros()
        {
            ViewBag.Informacion = informacion;
            ViewBag.SumaNumeros = CalcularSumaNumeros();
            return View();
        }
        [HttpPost]
        public IActionResult CapturarNombreNumero(string nombre,int numero) {
            var datos = new Datos { Nombre = nombre, Numero = numero };
            informacion.Add(datos);
            return RedirectToAction("NombresNumeros");
        }
        private int CalcularSumaNumeros() { 
            int suma = 0;
            foreach (Datos datos in informacion) {
                suma += datos.Numero;
            }
            return suma;
        }
    }
}
