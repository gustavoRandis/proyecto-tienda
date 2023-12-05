using Microsoft.Extensions.DependencyInjection;
using Presentador.PresentadorProducto;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoOutputPort;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;

namespace Presentador
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {

            services.AddScoped<ObtenerTodosProductosPresentador>();

            services.AddScoped<IObtenerTodosProductosOutputPort, ObtenerTodosProductosPresentador>();

            services.AddScoped<IObtenerTodosProductosPresentador, ObtenerTodosProductosPresentador>();

            services.AddScoped<ICrearProductoPresentador, CrearProductoPresentador>();
            services.AddScoped<IBorrarProductoPresentador, BorrarProductoPresentador>();
            services.AddScoped<IObtenerProductoPresentador, ObtenerProductoPresentador>();
            services.AddScoped<IActualizarProductoPresentador, ActualizarProductoPresentador>();
            return services;
        }
    }
}