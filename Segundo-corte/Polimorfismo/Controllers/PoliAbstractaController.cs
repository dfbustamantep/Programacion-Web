using Microsoft.AspNetCore.Mvc;
using Polimorfismo.Models;

namespace Polimorfismo.Controllers
{
    public class PoliAbstractaController : Controller
    {
        public IActionResult PolimorfismoA()
        {
            return View(new ModeloFigura());
        }

        [HttpPost]
        public IActionResult PolimorfismoA(ModeloFigura modelo)
        {
            OperacionAbsatracta rectangulo = new Rectangulo();
            OperacionAbsatracta trianangulo = new Triangulo();
            modelo.areaRectangulo = rectangulo.CalcularArea(modelo.mbase, modelo.altura);
            modelo.areaTrinagulo = trianangulo.CalcularArea(modelo.mbase, modelo.altura);
            return View(modelo);
        }
    }

    
}
