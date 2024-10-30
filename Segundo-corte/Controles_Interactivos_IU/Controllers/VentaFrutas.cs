using Controles_Interactivos_IU.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Controles_Interactivos_IU.Controllers
{
	public class VentaFrutas : Controller
	{
		public IActionResult Index()
		{
			ModeloFrutas datos = new ModeloFrutas
			{
				Frutas = new List<Fruteria> {
					new Fruteria {NombreFruta = "Mangos",ValorFruta=3000},
					new Fruteria {NombreFruta = "Uvas",ValorFruta=4800},
					new Fruteria {NombreFruta = "Moras",ValorFruta=1500},
					new Fruteria {NombreFruta = "Ciruelas",ValorFruta=5000},
				},
			};
			return View(datos);
		}

		[HttpPost]
		public double DescuentoFrutas(ModeloFrutas modelo)
		{
			if (modelo.Pago.Equals("Efectivo"))
			{
				return ViewBag.Descuento = 0.04;
			}
			if (modelo.Pago.Equals("Cheque"))
			{
				return ViewBag.Descuento = 0.02;
			}
			if (modelo.Pago.Equals("Credito"))
			{
				return ViewBag.Descuento = 0;
			}
			return 0;
		}

		public IActionResult Mostrar(ModeloFrutas modelo)
		{
			DescuentoFrutas(modelo);
			return View(modelo);
		}

	}

}
