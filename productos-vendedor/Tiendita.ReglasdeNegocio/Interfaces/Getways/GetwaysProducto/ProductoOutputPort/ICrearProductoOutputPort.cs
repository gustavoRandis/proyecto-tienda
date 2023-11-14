using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;


namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoOutputPort
{
    //Esta interfaz permite la implementación de diferentes estrategias para manejar la salida del caso de uso de creación de productos
    public interface ICrearProductoOutputPort
    {
        Task Handle(WrapperCrearProducto producto);
    }
}
