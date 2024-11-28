using BD_Basico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BD_Basico.Data
{
    //Herdeamos de DbContext para poder trabajar con una BD
    public class AplicacionBDContext : DbContext
    {
        //El parametro options contiene la configuracion de la base de datos   Con base() llamamos al constructor de la clase DbContext
        public AplicacionBDContext(DbContextOptions<AplicacionBDContext> options) : base(options) { }
        //DbSet se define la creacion de la tabla clientes
        public DbSet<Cliente> Clientes { get; set; }
    }
}