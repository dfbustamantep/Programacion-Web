using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_Aplicacion_Web_Core_MVC.Controllers
{
    // : herencia
    public class SaludoController : Controller
    {
        public IActionResult Index()
        {
            String mensaje = "Creacion de una primera aplicacion Web con ASP.NET Core.";
            // ViewBaf es una propiedad que permite compartir valores dinamicamewnte entre un controlador y una vista
            ViewBag.MensajeSaludo = mensaje;
            return View("Index");
            //return View();
        }
    }
}
