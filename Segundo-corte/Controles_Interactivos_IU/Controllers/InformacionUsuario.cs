using Controles_Interactivos_IU.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controles_Interactivos_IU.Controllers
{
    public class InformacionUsuario : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //Instancia de ModeloDatos 
            ModeloDatos datos = new ModeloDatos
            {
                Habilidades = new List<Habilidad> {
                    new Habilidad { NombreHabilidad="Autoconocimiento"},
                    new Habilidad { NombreHabilidad="Autocontrol"},
                    new Habilidad { NombreHabilidad="Autoconfianza"},
                    new Habilidad { NombreHabilidad="Comunicacion"},
                    new Habilidad { NombreHabilidad="Empatia"}
                },
            };
            return View(datos);
        }
        [HttpPost]
        public IActionResult Resultados(ModeloDatos modelo) { 
            return View(modelo);
        }
    }
}
