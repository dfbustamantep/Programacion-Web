using Microsoft.AspNetCore.Mvc;
using Operadores.Models;

namespace Operadores.Controllers
{
    public class OperadoresController : Controller
    {
        /*public IActionResult Index()
        {
            return View(new ModeloOperadores());
        }*/

        public IActionResult Index(ModeloOperadores modelo)
        {
            //ViewBag propiedad quee permite compartir valores dinamicamente entre un controlador y una vista
            ViewBag.Suma = modelo.Primero + modelo.Segundo;
            ViewBag.Resta = modelo.Primero - modelo.Segundo;
            ViewBag.Multiplicacion = modelo.Primero * modelo.Segundo;
            ViewBag.Division = modelo.Primero / modelo.Segundo;
            ViewBag.Incremento = ++modelo.Primero;
            ViewBag.Decremento = --modelo.Primero;
            return View(modelo);
        }
    }
}
