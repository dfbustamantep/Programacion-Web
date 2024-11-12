namespace Polimorfismo.Models
{
    public class Menor:OperacionHerencia
    {
        //Se define y se sobrescribe el metodo Calcular
        public override string Calcular(int primero, int segundo)
        {
            return "El menor es: "+(primero<segundo ? primero:segundo);
        }
    }
}
