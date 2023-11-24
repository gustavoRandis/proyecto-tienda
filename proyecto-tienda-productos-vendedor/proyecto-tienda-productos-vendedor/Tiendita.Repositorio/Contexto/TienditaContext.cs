using Microsoft.EntityFrameworkCore;
using reglasdenegocio.Entidades;
using System.Reflection;
using Tiendita.Repositorio.EFCore.Configuracion;

namespace Tiendita.Repositorio.Contexto
{
    // Este código define un contexto de base de datos llamado VideoClubContext
    // que hereda de DbContext en Entity Framework Core.
    namespace VideoClub.Repository.Contexto
    {
        public class TienditaContext : DbContext
        {
            // El constructor recibe opciones de configuración de DbContext.
            public TienditaContext(DbContextOptions<TienditaContext> options) : base(options) { }

            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseMySQL("Server = localhost; Port = 3306; Database = trailerfix; User = root; Password = MySql");

            //    //"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=LaPaulitaDB;Integrated Security=SSPI;"
            //}

            // DbSet define propiedades para acceder a las tablas en la base de datos.
            public DbSet<Producto> producto { get; set; } // Tabla de actores.
            //public DbSet<Catalogo> Catalogo { get; set; } // Tabla de catálogo.
            //public DbSet<Categoria> Categorias { get; set; } // Tabla de categorías.
            //public DbSet<Genero> Generos { get; set; } // Tabla de géneros.
            //public DbSet<GeneroTrailer> GenerosTrailer { get; set; } //Tabla GeneroTrailer.
            //public DbSet<Reparto> Reparto { get; set; } //Tabla Reparto.


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
