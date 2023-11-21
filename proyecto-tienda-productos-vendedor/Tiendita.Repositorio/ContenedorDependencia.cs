using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.Repositorio.Contexto;
using Tiendita.Repositorio.Contexto.VideoClub.Repository.Contexto;
using Tiendita.Repositorio.Repositorio;

namespace Tiendita.Repositorio
{
    public static class ContenedorDependencia
    {

        public static IServiceCollection AddServicesRepositories(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<TienditaContext>(options =>
            options.UseMySQL(configuration
            .GetConnectionString(connectionStringName)));

            services.AddScoped<IProductosRepository, ProductoRepositorio>();

            return services;
        }
    }
}
