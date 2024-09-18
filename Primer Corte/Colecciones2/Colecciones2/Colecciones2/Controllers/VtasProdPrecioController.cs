using Colecciones2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Colecciones2.Controllers
{
    public class VtasProdPrecioController : Controller
    {
        private static List<Productos> productos=new List<Productos>();
        public IActionResult VtasProdPrecio()
        {
            ViewBag.TotalProductos = CalcularTotalProductos();
            return View(productos);
        }
        [HttpPost]
        public IActionResult AgregarProducto(string nombre,int cantidad) {
            decimal precio = 0;
            if (nombre.Equals("Uvas"))
                precio = 2000;
            if (nombre.Equals("Piñas"))
                precio = 2500;
            if (nombre.Equals("Kiwis"))
                precio = 3000;
            if (nombre.Equals("Melones"))
                precio = 5000;
            if (nombre.Equals("Naranja"))
                precio = 1800;
            productos.Add(new Productos { Nombre = nombre, Cantidad = cantidad, Precio = precio, Subtotal = precio * cantidad });
            return RedirectToAction("VtasProdPrecio");
        }
        private double CalcularTotalProductos()
        {
            double total = 0;
            foreach (Productos prodcuto in productos) {
                total += (prodcuto.Cantidad);
            }
            return total;
        }
    }
}
