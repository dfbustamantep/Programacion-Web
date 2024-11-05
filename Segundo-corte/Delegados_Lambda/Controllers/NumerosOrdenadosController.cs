using Microsoft.AspNetCore.Mvc;

namespace Delegados_Lambda.Controllers
{
    public class NumerosOrdenadosController : Controller
    {
        //Lista generica para guardar numeros enteros
        private static List <int> numeros = new List<int> ();
        //Se define un delegado con retorno que recibe un parametro entero
        public delegate void DelegadoAdicionarNumeros(int numero);
        //Creamos una instancia de nuestro delegado y le asignamos la funcion AdicionarNumerosLista
        public static DelegadoAdicionarNumeros AdicionarNumeros = AdicionarNumerosLista;

        public static void AdicionarNumerosLista(int numero)
        {
            numeros.Add (numero);
        }
        public IActionResult OrdenarDL()
        {
            ViewBag.Originales = new List<int> (numeros);
            var numerosordenados = new List<int> (numeros);
            numerosordenados.Sort();
            ViewBag.NumerosOrdenados = numerosordenados;
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarNuevoNumero(int numero)
        {
            AdicionarNumeros(numero);
            return RedirectToAction("OrdenarDL");
        }

        public IActionResult OrdenarFL()
        {
            ViewBag.Originales = numeros;
            //Le asignamos una funcion lambda que ordena la lista de numeros y los muestra con la funcion toList
            ViewBag.NumerosOrdenados = numeros.OrderBy(n => n).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult OrdenarFL(string Numero)
        {
            if (int.TryParse(Numero,out int numero))
            {
                numeros.Add(numero);
            }
            ViewBag.Originales = numeros;
            ViewBag.NumerosOrdenados = numeros.OrderBy (n => n).ToList();
            return View();

        }
    }
}
