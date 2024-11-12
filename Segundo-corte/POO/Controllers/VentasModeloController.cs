using Microsoft.AspNetCore.Mvc;
using POO.Models;

namespace POO.Controllers
{
	public class VentasModeloController : Controller
	{
		private static List<Productos> productos = new List<Productos>();

		public IActionResult VentasModelo()
		{
			var modelo = new ModeloVentas
			{
				MProductos = productos,
				//Fucnion lambda para obtener la sumatoria de la propiedad TotalVenta
				TotalVentas=productos.Sum(p=>p.TotalVenta)
			};

			return View(modelo);
		}

		[HttpPost]
		public IActionResult AgregarProducto(ModeloVentas modelo) {
			var producto = new Productos
			{
				nombre = modelo.MProducto.nombre,
				nit = modelo.MProducto.nit,
				nombreProducto = modelo.MProducto.nombreProducto,
				cantidad = modelo.MProducto.cantidad,
				precio = modelo.MProducto.precio
			};
			productos.Add(producto);
			return RedirectToAction("VentasModelo");
		}
	}
}
