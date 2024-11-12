namespace Polimorfismo.Models
{
    public class Producto:OperacionHerencia
    {
        //Definimos y sobrescribimos (Override) el metodo calcular 
        public override string Calcular(int primero, int segundo)
        {
            return "El producto es: "+(primero * segundo);
        }
    }
}
