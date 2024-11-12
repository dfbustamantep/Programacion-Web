using Microsoft.AspNetCore.Mvc;
using POO.Models;

namespace POO.Controllers
{
	public class FrutasController : Controller
	{
		private static Frutas _frutas = new Frutas();
		public IActionResult Index()
		{
			return View(_frutas);
		}
		[HttpPost]
		public IActionResult Index (string identificacion,string ciudad,string producto,int cantidad)
		{
			_frutas.AgregarVenta(identificacion, ciudad,producto,cantidad);
			return View(_frutas);
		}
	}
}
