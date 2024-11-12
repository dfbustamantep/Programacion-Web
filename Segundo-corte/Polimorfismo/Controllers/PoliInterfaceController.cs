using Microsoft.AspNetCore.Mvc;
using Polimorfismo.Models;

namespace Polimorfismo.Controllers
{
    public class PoliInterfaceController : Controller
    {
        public IActionResult Polimorfismol()
        {
            return View(new ModeloPolimorfismo());
        }

        
        [HttpPost]
        public IActionResult Polimorfismol(ModeloPolimorfismo modelo, string operacion)
        {
            OperacionInterface opcion;
            switch (operacion)
            {
                case "Suma":
                    opcion = new Sumar();
                    break;
                case "Resta":
                    opcion = new Restar();
                    break;
                case "Multiplicacion":
                    opcion = new Multiplicar();
                    break;
                case "Division":
                    opcion = new Dividir();
                    break;
                default:
                    throw new InvalidOperationException("Operacion no valida");
            }
            modelo.resultado = opcion.Cacluclar(modelo.primero, modelo.segundo);
            return View(modelo);
        }

    }

    
}
