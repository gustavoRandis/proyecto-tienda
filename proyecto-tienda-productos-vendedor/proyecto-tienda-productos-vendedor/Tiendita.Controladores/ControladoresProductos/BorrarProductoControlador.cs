using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.Controladores.ControladoresProductos
{

    public class BorrarProductoControlador : IBorrarProductoControlador
    {
        readonly IBorrarProductoInputPort _inputPort;
        readonly IBorrarProductoPresentador _presenter;

        public BorrarProductoControlador(IBorrarProductoInputPort inputPort, IBorrarProductoPresentador presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperBorrarProducto> BorrarProducto(int IdProducto)
        {
            await _inputPort.Handle(IdProducto);
            return _presenter.Producto;
        }
    }
}

