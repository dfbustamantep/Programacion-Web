namespace Polimorfismo.Models
{
    public class Sumar : OperacionInterface
    {
        //Implementamos el metodo de la interface
        public string Cacluclar(double primero, double segundo)
        {
            return "La suma es: " + (primero + segundo);
        }
    }
}
