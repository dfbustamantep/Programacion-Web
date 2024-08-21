using Microsoft.AspNetCore.Mvc;

namespace SI_MVC.Controllers
{
    public class SaludoController : Controller
    {
        public IActionResult Index()
        {
            string mensaje = " creacion de una pagina que te resuelve la vida xd";
            ViewBag.mensajeSaludo = mensaje;
            return View("Index");
        }
    }
}
