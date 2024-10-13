using Microsoft.AspNetCore.Mvc;

namespace Estrucutras_de_control.Controllers
{
	public class MayorMenorController : Controller
	{
		public IActionResult MayorMenor()
		{
			return View();
		}
		[HttpPost]
		public IActionResult EncontrarMayorMenor(int primero,int segundo,int tercero)
		{
			int mayor = 0, menor = 0;
            if (primero>=segundo && primero>+ tercero)
            {
				mayor = primero;
				if (segundo < tercero)
				{
					menor = segundo;
				}
				else { 
					menor = tercero;
				}
            }

            if (segundo>=primero && segundo >= tercero)
            {
				mayor = segundo;
				if (primero < tercero) { 
					menor = primero;
				}
				else
				{
					menor = tercero; 
				}
            }

            if (tercero >= primero)
			{
				mayor=tercero;
				if (primero < segundo) { 
					menor =primero;
				}
                else
                {
                    menor=segundo;
                }
                
                
            }
			// ViewVag permite compartir valores dinamicamente entre un controlador y una vista
			ViewBag.Numeros = "Los numeros digitados fueron:" + primero + "," + segundo + "," + tercero;
			ViewBag.MayorNumero = mayor;
			ViewBag.MenorNumero = menor;
			return View("MayorMenor");
        }
	}
}
