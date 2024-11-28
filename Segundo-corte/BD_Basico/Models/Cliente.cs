using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BD_Basico.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nit {  get; set; }
        [Required]
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad {  get; set; }
    }
}
