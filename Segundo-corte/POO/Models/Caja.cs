namespace POO.Models
{
    public class Caja
    {
        public double Alto {  get; set; }
        public double Ancho { get; set; }
        public double Profundidad { get; set; }
        // Constructor sin parametros
        public Caja()
        {

        }
        // Constructor con parametros
        public Caja(double alto, double ancho, double profundidad)
        {
            Alto = alto;
            Ancho = ancho;
            Profundidad = profundidad;  
        }
        public double Volumen()
        {
            return Alto*Ancho*Profundidad;
        }
    }
}
