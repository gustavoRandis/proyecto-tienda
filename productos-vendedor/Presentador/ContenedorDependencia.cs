using Presentador.PresentadorProducto;

namespace Presentador
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {

            services.AddScoped<ICrearProductoPresentador, CrearProductoPresentador>();

        }
    }
}