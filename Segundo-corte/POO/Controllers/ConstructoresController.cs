using Microsoft.AspNetCore.Mvc;
using POO.Models;

namespace POO.Controllers
{
    public class ConstructoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalcularVolumen(double alto, double ancho, double profundidad, string boton) {
            Caja caja;
            double volumen = 0;
            if (boton == "cp")
            {
                caja = new Caja(alto, ancho, profundidad);
                volumen = caja.Volumen();
            }
            else if(boton == "sp") {
                caja = new Caja();  
                caja.Alto= alto;
                caja.Ancho= ancho;
                caja.Profundidad= profundidad;
                volumen= caja.Volumen();
            }
            ViewBag.Volumen = volumen;  
            return View("Index");
            }
    }
}
