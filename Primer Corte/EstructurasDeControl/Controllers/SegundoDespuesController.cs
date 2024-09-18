using Estructuras_de_Control.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estructuras_de_Control.Controllers
{
    public class SegundoDespuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UnSegundo(ModeloNumeros modelo) {
            if (modelo.horas == 23 && modelo.segundos == 59 && modelo.minutos == 59)
            {
                modelo.horas = modelo.minutos = modelo.segundos = 0;
            }
            else {
                if (modelo.minutos == 59 && modelo.segundos == 59)
                {
                    modelo.horas++;
                    modelo.minutos = modelo.segundos = 0;
                }
                else {
                    if (modelo.segundos == 59)
                    {
                        modelo.minutos++;
                        modelo.segundos = 0;
                    }
                    else { 
                        modelo.segundos++;
                    }
                }
            }

            ViewBag.Horas = modelo.horas;
            ViewBag.Minutos=modelo.minutos;
            ViewBag.Segundos=modelo.segundos;
            return View("Index");
        }
    }
}
