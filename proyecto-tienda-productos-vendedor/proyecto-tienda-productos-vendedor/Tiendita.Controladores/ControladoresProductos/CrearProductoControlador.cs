using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

//Se encarga de orquestar la creación de productos al interactuar con las capas de entrada (ICrearProductoInputPort) y 
//presentación(ICrearProductoPresentador). Su principal función es recibir una solicitud para crear un producto (CrearProductoDTO),
//pasar esta solicitud al puerto de entrada correspondiente (_inputPort), y devolver la respuesta resultante encapsulada en un objeto
//WrapperCrearProducto a través del presentador (_presenter). 


namespace Tiendita.Controladores.ControladoresProductos
{
    public class CrearProductoControlador : ICrearProductoControlador
    {
        readonly ICrearProductoInputPort _inputPort;
        readonly ICrearProductoPresentador _presenter;

        public CrearProductoControlador(ICrearProductoInputPort inputPort, ICrearProductoPresentador presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperCrearProducto> CrearProducto(CrearProductoDTO request)
        {
            await _inputPort.Handle(request);
            return _presenter.producto;
        }
    }
}
