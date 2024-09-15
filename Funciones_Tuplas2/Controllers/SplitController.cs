using Microsoft.AspNetCore.Mvc;

namespace Funciones_Tuplas2.Controllers
{
    public class SplitController : Controller
    {
        //cambiamos el indexx por Split
        public IActionResult Split()
        {
            return View();
        }
        public IActionResult funcionSplit(Models.ModeloTexto modelo, string boton)
        {
            switch (boton)
            {
                case "btnpalabras":
                    funcion_palabras(modelo.texto);
                    ViewBag.Informacion = "btnpalabras";
                    break;

                case "btnordenadas":
                    funcion_palabras(modelo.texto);
                    ViewBag.Informacion = "btnordenadas";
                    break;

                case "btncontieneo":
                    funcion_palabras(modelo.texto);
                    ViewBag.Informacion = "btncontieneo";
                    break;

                case "btnterceran":
                    funcion_palabras(modelo.texto);
                    ViewBag.Informacion = "btnterceran";
                    break;

                case "btninvertida":
                    funcion_palabras(modelo.texto);
                    ViewBag.Informacion = "btninvertida";
                    break;

                case "btnempieces":
                    funcion_palabras(modelo.texto);
                    ViewBag.Informacion = "btnempieces";
                    break;
            }
            return View("Split");
        }    
        public void funcion_palabras(string cadena)
        {
            string[] separar = cadena.Split(' ');
            ViewBag.Separar = separar;
        }
    }
}
