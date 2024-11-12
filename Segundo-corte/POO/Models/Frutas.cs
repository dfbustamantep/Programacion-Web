namespace POO.Models
{
	//La clase Frutas hereda de la clase Clientes
	public class Frutas : Clientes
	{
		public List<ModeloFrutas> VentasFR = new List<ModeloFrutas>();

		private decimal ObtenerPrecio(string producto)
		{
			switch (producto)
			{
				case "Piñas":
					return 3000;
				case "Naranjas":
					return 2500;
				case "Moras":
					return 3500;
				case "Cerezas":
					return 4000;
				case "Mangos":
					return 4500;
				default:
					return 0;
			}
		}
		public void AgregarVenta(string identifiacion, string ciudad, string producto, int cantidad)
		{
			var venta = new ModeloFrutas
			{
				Identificacion = identifiacion,
				Ciudad = ciudad,
				Producto = producto,
				Cantidad = cantidad,
				Precio = ObtenerPrecio(producto),
				Tpagar = cantidad * ObtenerPrecio(producto),
			};
			VentasFR.Add(venta);
		}
		public decimal TotalVentas => VentasFR.Sum(v => v.Tpagar);
	}
}
