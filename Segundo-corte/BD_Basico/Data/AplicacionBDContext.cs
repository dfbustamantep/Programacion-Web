using BD_Basico.Models;
using Microsoft.EntityFrameworkCore;

namespace BD_Basico.Data
{
    //Se hereda de la clase DbContext para trabajar con una base de datos
    public class AplicacionBDContext:DbContext
    {
        //El constructor tiene el parametros options (configuracion de la BD)
        //:base llama al constructor de la clase DbContext
        public AplicacionBDContext(DbContextOptions<AplicacionBDContext> options) : base(options) { }
        //DbSet se define la creacion de la tabla Cliente
        public DbSet<Cliente> Clientes { get; set;}

        public DbSet<Pedido> Pedidos { get; set; }
    }


}
