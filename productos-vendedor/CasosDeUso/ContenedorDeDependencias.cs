using CasosDeUso.CasosUso.CasosUsoProducto;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort;

namespace CasosDeUso
{
    public static class ContenedorDeDependencias
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICrearProductoInputPort, CrearProductoIteractor>();

            //services.AddScoped<IBorrarProductoInputPort, BorrarProductoIteractor>();

            //services.AddScoped<IActualizarProductoInputPort, ActualizarProductoIteractor>();

            //services.AddScoped<IObtenerProductoInputPort, ObtenerProductoIteractor>();

            //services.AddScoped<IObtenerTodosProductosInputPort, ObtenerTodosProductosIteractor>();

            return services;

        }
    }
}
