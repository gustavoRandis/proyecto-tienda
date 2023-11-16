using Microsoft.Extensions.DependencyInjection;
using Tiendita.Presenters.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;

namespace Tiendita.Presenters
{
    public static class ContenedorDependencia
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {
            

            services.AddScoped<ICrearClientePresenter, CrearClientePresenter>();

            services.AddScoped<ITraerClienteIdPresenter, TraerClienteIdPresenter>();

            services.AddScoped<IBorrarClientePresenter, BorrarClientePresenter>();
            return services;
        }
    }
}
