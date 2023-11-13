using CasosDeUso;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presentador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Controladores;
using Tiendita.Repositorio;

namespace InversionDependencia.cs
{
    public static class ContenedorDependencia
    {
        public static IServiceCollection AddTienditaServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            services
                .AddServicesRepositories(configuration, connectionString)
                .AddServicesUseCases()
                .AddServicesPresenter()
                .AddServicesControllers();

            return services;
        }   
    }
}
