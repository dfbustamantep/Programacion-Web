using Colecciones2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Colecciones2.Controllers
{
    public class VentaProductosController : Controller
    {
        private static List<DatosProductos> ventas = new List<DatosProductos>();
        //private static ArrayList ventas = new ArrayList();
        public IActionResult Ventas()
        {
            ViewBag.Venta = ventas;
            ViewBag.TotalVenta = CalcularTotalVenta();
            return View();
        }
        [HttpPost]
        public IActionResult AgregarProducto(string producto, int cantidad, double precio)
        {
            if (cantidad > 0 || precio > 0) {
                var adicionarProducto = new DatosProductos
                {
                    producto = producto,
                    cantidad = cantidad,
                    precio = precio
                };
                ventas.Add(adicionarProducto);
            }
            return RedirectToAction("Ventas");
        }

        private double CalcularTotalVenta() {
            double total = 0;
            foreach (DatosProductos venta in ventas) {
                total += (venta.precio * venta.cantidad);
            }
            return total;
        }

    }
}
