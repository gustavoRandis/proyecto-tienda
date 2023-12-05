using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.Controladores.ControladoresProductos
{
    public class ActualizarProductoControlador : IActualizarProductoControlador
    {
        public Task<WrapperCrearProducto> ActulizarProducto(ActualizacionProductoDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
