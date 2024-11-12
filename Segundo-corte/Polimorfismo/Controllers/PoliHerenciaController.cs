using Microsoft.AspNetCore.Mvc;
using Polimorfismo.Models;

namespace Polimorfismo.Controllers
{
    public class PoliHerenciaController : Controller
    {
        public IActionResult PolimorfismoH()
        {
            return View(new ModeloPolimorfismo());
        }

        [HttpPost]
        public IActionResult PolimorfismoH(ModeloPolimorfismo modelo, string operacion)
        {
            OperacionHerencia opcion;
            switch (operacion)
            {
                case "Producto":
                    opcion = new Producto();
                    break;
                case "Potencia":
                    opcion = new Potencia();
                    break;
                case "Mayor":
                    opcion = new Mayor();
                    break;
                case "Menor":
                    opcion = new Menor();
                    break;
                default:
                    throw new InvalidOperationException("Operacion no vallida");
            }
            modelo.resultado = opcion.Calcular(modelo.primero, modelo.segundo);
            return View(modelo);

        }
    }
}
