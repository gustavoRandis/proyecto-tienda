using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Presentador.PresentadorProducto
{
    public class BorrarProductoPresentador : IBorrarProductoPresentador
    {
        public WrapperBorrarProducto Producto { get; private set; } = new WrapperBorrarProducto();

        public Task Handle(WrapperBorrarProducto producto)
        {
            Producto.NumeroError = producto.NumeroError;
            Producto.Mensaje = producto.Mensaje;
            Producto.IdProducto = producto.IdProducto;
            return Task.CompletedTask;
        }
    }
}
