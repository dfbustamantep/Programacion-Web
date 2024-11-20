using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BD_Basico.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NroPedido { get; set; }
        public int Nit { get; set; }
        public DateOnly Fecha { get; set; }
        public string Comentario { get; set; }
    }
}
