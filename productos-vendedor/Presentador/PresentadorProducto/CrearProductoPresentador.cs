using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Presentador.PresentadorProducto
{
    //Este código implementa la clase CrearProductoPresentador, que actúa como un presentador para el caso de uso de creación de productos
    public class CrearProductoPresentador : ICrearProductoPresentador
    {
        public WrapperCrearProducto producto { get; private set; } = new WrapperCrearProducto();

        public Task Handle(WrapperCrearProducto producto)
        {
            producto.NumeroError = producto.NumeroError;
            producto.ValidacionErrores = producto.ValidacionErrores;
            producto.Mensaje = producto.Mensaje;
            producto.IdProducto = producto.IdProducto;
            return Task.CompletedTask;
        }
    }

}
