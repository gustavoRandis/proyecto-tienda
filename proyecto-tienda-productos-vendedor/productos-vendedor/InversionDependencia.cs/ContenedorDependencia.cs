using CasosDeUso;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presentador;
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
                .AddServicesControllers()
                .AddServicesPresenter();

            return services;
        }   
    }
}
