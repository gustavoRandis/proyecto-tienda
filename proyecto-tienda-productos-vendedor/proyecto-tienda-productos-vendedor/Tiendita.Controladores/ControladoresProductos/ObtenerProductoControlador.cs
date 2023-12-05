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
    public class ObtenerProductoControlador : IObtenerProductoControlador
    {
        readonly IObtenerProductoInputPort _inputPort;
        readonly IObtenerProductoPresentador _presenter;

        public ObtenerProductoControlador(IObtenerProductoInputPort inputPort, IObtenerProductoPresentador presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        async Task<WrapperObtenerProducto> IObtenerProductoControlador.ObtenerProducto(int IdProducto)
        {
            await _inputPort.Handle(IdProducto);
            return _presenter.Producto;
        }
    }
}
