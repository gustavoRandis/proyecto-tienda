using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.Repositorio.Repositorio;

namespace Tiendita.Repositorio
{
    public static class ContenedorDependencia
    {

        public static IServiceCollection AddServicesRepositories(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<Tiendita.Context>(options =>
            options.UseMySQL(configuration
            .GetConnectionString(connectionStringName)));

            services.AddScoped<IProductosRepository, ProductoRepositorio>();

            return services;
        }
    }
}
