namespace Polimorfismo.Models
{
    public class Triangulo : OperacionAbsatracta
    {
        public override string CalcularArea(double mbase, double altura)
        {
            return "El area del triangulo es: "+((mbase*altura)/2);
        }
    }
}
