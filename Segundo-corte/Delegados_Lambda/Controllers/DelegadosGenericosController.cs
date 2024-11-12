using Microsoft.AspNetCore.Mvc;

namespace Delegados_Lambda.Controllers
{
    public class DelegadosGenericosController : Controller
    {
		//Delegado generico que recibe dos parametros
		public delegate T DelegadoMultiplicacion<T>(T a, T b);
		//Creamos una instancia estatica
		public static DelegadoMultiplicacion<double> MultiplicarNumeros = Multiplicacion;

		//public static Func<double, double, double> MultiplicarNumeros = Multiplicacion;
		//implementamos la funcion estatatica
		public static double Multiplicacion(double primero, double segundo)
        {
            //Console.WriteLine(primero * segundo);
            return primero * segundo;
        }


        public IActionResult DelegadosT()
        {
            ViewBag.Producto = 0.0; 
            return View();
        }

        [HttpPost]
        public IActionResult CalcularProducto(double primero, double segundo)
        {
            DelegadoMultiplicacion<double> MultiplicarNumeros = (a, b) => a * b;
            double resultado = MultiplicarNumeros(primero, segundo);
            ViewBag.Producto = resultado;
            return View("DelegadosT");
        }
    }
}
