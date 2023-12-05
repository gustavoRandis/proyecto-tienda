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
    public class ObtenerTodosProductosControlador : IObtenerTodosProductosControlador
    {
        readonly IObtenerTodosProductosInputPort _inputPort;
        readonly IObtenerTodosProductosPresentador _presenter;

        public ObtenerTodosProductosControlador(IObtenerTodosProductosInputPort inputPort, IObtenerTodosProductosPresentador presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<WrapperObtenerTodosProductos> ObtenerTodos()
        {
            await _inputPort.Handle();
            return _presenter.Productos;
        }
    }
}
