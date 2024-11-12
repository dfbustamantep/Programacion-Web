namespace Polimorfismo.Models
{
    public class Mayor:OperacionHerencia
    {
        //Se definbe y se sobrescribe el metodo Calcular
        public override string Calcular(int primero, int segundo)
        {
            return "El mayor es: "+(primero>segundo?primero:segundo);
        }
    }
}
