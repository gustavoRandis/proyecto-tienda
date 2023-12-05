using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Controladores.ControladoresProductos;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;

namespace Tiendita.Controladores
{
    // este código configura el contenedor de dependencias para incluir la implementación CrearProductoControlador
    // cuando se solicita la interfaz ICrearProducto. 
    public static class ContenedorDependenci
    {
        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICrearProductoControlador, CrearProductoControlador>();

            services.AddScoped<IBorrarProductoControlador, BorrarProductoControlador>();

            services.AddScoped<IActualizarProductoControlador, ActualizarProductoControlador>();

            services.AddScoped<IObtenerProductoControlador, ObtenerProductoControlador>();

            services.AddScoped<IObtenerTodosProductosControlador, ObtenerTodosProductosControlador>();

            return services;

        }
    }
}
