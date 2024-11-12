namespace POO.Models
{
    public class Productos : Empresa
    {
        public string nombreProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        //Funcion lambda para calcular el total de la venta
        public decimal TotalVenta => cantidad * precio;
    }
}