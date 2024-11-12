namespace Polimorfismo.Models
{
    public class Rectangulo : OperacionAbsatracta
    {
        public override string CalcularArea(double mbase, double altura)
        {
            return "El area del rectangulo es: "+(mbase * altura);
        }
    }
}
