namespace Polimorfismo.Models
{
    public class Dividir : OperacionInterface
    {
        //Implementamos el metodo de la interfaz
        public string Cacluclar(double primero, double segundo)
        {
            if (segundo == 0) {
                return "No se puede dividir por cero";
            }
            return "La division es : " + (primero / segundo);
        }
    }
}
