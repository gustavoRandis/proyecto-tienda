using Microsoft.Extensions.DependencyInjection;
using Tiendita.Controllers.ClienteController;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;

namespace Tiendita.InyeccionDependecia
{
    public static class ContenedorDependencia
    {
        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {

            services.AddScoped<ICrearClienteController, CrearClienteController>();

            services.AddScoped<ITraerClienteIdController, TraerClienteIdController>();
           
            services.AddScoped<IBorrarClienteController, BorrarClienteController>();


            

            return services;

        }
    }
}

