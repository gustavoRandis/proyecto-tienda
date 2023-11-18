using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoOutputPort
{
    public interface IActualizarProductoOutputPort
    {
        Task handle(WrapperActualizarProducto Producto);
    }
}
