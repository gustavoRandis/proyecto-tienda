using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoOutputPort;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador
{
    public interface ICrearActorPresentador:ICrearProductoOutputPort
    {
        WrapperCrearProducto producto { get; }
    }
}
