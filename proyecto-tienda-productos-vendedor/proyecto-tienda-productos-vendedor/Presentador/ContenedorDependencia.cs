using Microsoft.Extensions.DependencyInjection;
using Presentador.PresentadorProducto;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;

namespace Presentador
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {

            services.AddScoped<ICrearProductoPresentador, CrearProductoPresentador>();
            services.AddScoped<IBorrarProductoPresentador, BorrarProductoPresentador>();
            return services;
        }
    }
}