using Microsoft.EntityFrameworkCore;
using reglasdenegocio.Entidades;

namespace MecagoEnTdo.WebApi.date
{
    public class appdbcontext : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Publicacion> publicaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=127.0.0.1;port=3306;database=tiendita;user=root;password=root;";
            var serverVersion = new MySqlServerVersion(new Version(5, 5));

            optionsBuilder.UseMySql(connectionString, serverVersion);



        }
    }
}
