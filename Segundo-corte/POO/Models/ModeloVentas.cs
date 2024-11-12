namespace POO.Models
{
	public class ModeloVentas
	{
		public Productos MProducto { get; set; }
		public List<Productos> MProductos { get; set; }
		public decimal TotalVentas { get; set; }
		public ModeloVentas()
		{
			MProducto = new Productos();
			MProductos = new List<Productos>();
		}
	}
}
