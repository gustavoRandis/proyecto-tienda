using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos
{
    public interface IObtenerProductoControlador
    {
        Task<WrapperObtenerProducto> ObtenerProducto(int IdProducto);
    }
}
