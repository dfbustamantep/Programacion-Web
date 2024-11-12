namespace Polimorfismo.Models
{
    public class Multiplicar : OperacionInterface
    {
        public string Cacluclar(double primero, double segundo)
        {
            return "La multiplicacion es:" + (primero * segundo);
        }
    }
}
