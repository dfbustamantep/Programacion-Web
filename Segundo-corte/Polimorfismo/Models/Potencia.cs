namespace Polimorfismo.Models
{
    public class Potencia:OperacionHerencia
    {
        //Se define y se sobrescribe el metodo Calcular
        public override string Calcular(int primero, int segundo)
        {
            return "La potencia es:"+(int)Math.Pow(primero, segundo);
        }
    }
}
