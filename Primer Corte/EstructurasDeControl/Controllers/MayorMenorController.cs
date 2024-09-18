using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Estructuras_de_Control.Controllers
{
    public class MayorMenorController : Controller
    {
        public IActionResult MayorMenor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EncontrarMayorMenor(int primero, int segundo, int tercero)
        {
            int mayor=0,menor=0;
            if (primero >= segundo && primero >= tercero) {
                mayor = primero;

                if (segundo < tercero) {
                    menor = segundo;
                }
                else { 
                    menor= tercero;
                }
            }
            if (segundo >= primero && segundo >= tercero) {
                mayor = segundo;
                if (primero < tercero)
                {
                    menor = primero;
                }
                else {
                    menor = tercero;
                }
            }
            if (tercero >= primero && tercero >= segundo) {
                mayor = tercero;
                if (primero < segundo)
                {
                    menor = primero;
                }
                else {
                    menor = segundo;
                }
            }
            ViewBag.Numeros = "Los numeros digitados fueron: " + primero + "," + segundo + "," + tercero;
            ViewBag.MayorNumero = mayor;
            ViewBag.MenorNumero = menor;
            return View("MayorMenor");
        }
    }
}

