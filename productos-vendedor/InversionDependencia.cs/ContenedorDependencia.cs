using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependencia.cs
{
    public static class ContenedorDependencia
    {
        public static IServiceCollection AddTienditaServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            services
                .AddServicesRepositorio(configuration, connectionString)
                .AddServicesUseCases()
                .AddServicesPresenter()
                .AddServicesControllers();

            return services;
        }   
    }
}
