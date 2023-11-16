using Microsoft.EntityFrameworkCore;
using reglasdenegocio.Entidades;

namespace Tiendit.WebApi.Models
{
    public class MydbContext : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Publicacion> publicaciones { get; set; }

        public MydbContext(DbContextOptions<MydbContext> options) : base(options)
        {

        }
    }
}
