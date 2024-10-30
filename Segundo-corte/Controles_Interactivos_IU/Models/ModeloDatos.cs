namespace Controles_Interactivos_IU.Models
{
    public class ModeloDatos
    {
        public string Nombres {  get; set; }
        public string Apellidos { get; set; }
        public string Genero {  get; set; }
        public List<string> Deportes { get; set; }
        public string Aficion {  get; set; }
        public string Estudios { get; set; }
        public string Ingles { get; set; }
        public string Idioma { get; set; }
        public List<Habilidad> Habilidades { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Color { get; set; }
        public string Comentarios { get; set; }
    }
}
