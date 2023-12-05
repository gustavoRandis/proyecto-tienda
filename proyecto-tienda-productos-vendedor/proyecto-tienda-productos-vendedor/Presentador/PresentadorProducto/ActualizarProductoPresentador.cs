using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Presentador.PresentadorProducto
{
    public class ActualizarProductoPresentador : IActualizarProductoPresentador
    {
        public WrapperActualizarProducto Producto => throw new NotImplementedException();

        public Task Handle(WrapperActualizarProducto producto)
        {
            throw new NotImplementedException();
        }
    }
}
