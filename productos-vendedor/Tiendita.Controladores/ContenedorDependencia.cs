﻿using Microsoft.Extensions.DependencyInjection;
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
            services.AddScoped<ICrearProducto, CrearProductoControlador>();

            //services.AddScoped<IDeleteActorController, DeleteActorController>();

            //services.AddScoped<IUpdateActorController, UpdateActorController>();

            //services.AddScoped<IGetActorByIdController, GetActorByIdController>();

            //services.AddScoped<IGetAllActorController, GetAllActorController>();

            return services;

        }
    }
}
