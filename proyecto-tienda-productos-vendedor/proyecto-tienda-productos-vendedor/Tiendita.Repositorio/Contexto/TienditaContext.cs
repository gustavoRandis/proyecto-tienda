using Microsoft.EntityFrameworkCore;
using reglasdenegocio.Entidades;
using System.Reflection;
using Tiendita.Repositorio.EFCore.Configuracion;

namespace Tiendita.Repositorio.Contexto
{
    // Este código define un contexto de base de datos llamado tienditacontext
    // que hereda de DbContext en Entity Framework Core.
    namespace VideoClub.Repository.Contexto
    {
        public class TienditaContext : DbContext
        {
            // El constructor recibe opciones de configuración de DbContext.

            public TienditaContext(DbContextOptions<TienditaContext> options) : base(options) { }

            // DbSet define propiedades para acceder a las tablas en la base de datos.
            public DbSet<Producto> producto { get; set; } // Tabla de productos.

            // Este método se llama al configurar el modelo de base de datos.
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Aplica configuraciones de entidades desde el ensamblado actual.
                modelBuilder.ApplyConfigurationsFromAssembly(
                    Assembly.GetExecutingAssembly());
               
            }
        }
    }
}
