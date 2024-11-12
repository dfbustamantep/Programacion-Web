namespace Polimorfismo.Models
{
    public class Restar : OperacionInterface
    {
        public string Cacluclar(double primero, double segundo)
        {
            return "La resta es:" + (primero - segundo);
        }
    }
}
