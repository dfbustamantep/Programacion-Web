using Microsoft.AspNetCore.Mvc;
using POO.Models;

namespace POO.Controllers
{
	public class VentasController : Controller
	{
		private static List<Productos> productos = new List<Productos>();
		public IActionResult Ventas()
		{
			ViewBag.TotalVentas = productos.Sum(p => p.TotalVenta);
			return View(productos);
		}
		[HttpPost]
		public IActionResult AgregarVenta(string nombre, string nit, string nombreProducto, int cantidad,
	   decimal precio)
		{
			var producto = new Productos
			{
				nit = nit,
				nombre = nombre,
				nombreProducto = nombreProducto,
				cantidad = cantidad,
				precio = precio
			};
			productos.Add(producto);
			return RedirectToAction("Ventas");
		}
	}
}

