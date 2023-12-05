using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Presentador.PresentadorProducto
{
    public class ObtenerProductoPresentador : IObtenerProductoPresentador
    {
        public WrapperObtenerProducto Producto { get; private set; }

        public Task Handle(WrapperObtenerProducto producto)
        {
            Producto = new WrapperObtenerProducto
            {
                IdProducto = producto.IdProducto,
                Nombre = producto.Nombre,
                NumeroError = producto.NumeroError,
                Mensaje = producto.Mensaje
            };
            return Task.CompletedTask;
        }
    }
}
