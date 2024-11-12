using Login_Basico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login_Basico.Controllers
{
    public class AccesoController : Controller
    {

        public IActionResult Index()
        {
            //Retorna la vista actual
            return View();
        }

        [HttpPost]
        public IActionResult Index (ModeloLogin modelo)
        {
            if(modelo.Correo.Equals("admin@gmail.com")&& modelo.Contraseña.Equals("123456"))
            {
                //Si la validadcion es correcta se crea un objeto Session de tipo HttpContext al caul le asignamos el correo y
                //redireccionamos al index del controlador home
                HttpContext.Session.SetString("Usuario",modelo.Correo);
                TempData["Usuario"] = modelo.Correo;
                return RedirectToAction("Index","Home");
            }
            ViewBag.Error = "Error en el correo y/o en la contraseña";
            return View();
        }
        public IActionResult Salir()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Acceso");
        }
    }
}
