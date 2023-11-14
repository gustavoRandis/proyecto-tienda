using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoOutputPort;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador
{
    //Esta interfaz sirve como un contrato para los presentadores que manejan la salida del caso de uso de creación de productos,
    //proporcionando una forma de acceder al resultado del caso de uso desde el código que utiliza este presentador.
    public interface ICrearProductoPresentador:ICrearProductoOutputPort
    {
        WrapperCrearProducto producto { get; }
    }
}
