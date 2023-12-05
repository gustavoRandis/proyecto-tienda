using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace CasosDeUso.CasosUso.CasosUsoProducto
{
    public class ObtenerProductoIteractor : IObtenerProductoInputPort
    {
        private readonly IProductosRepository _repository;
        private readonly IObtenerProductoPresentador _presenter;

        public ObtenerProductoIteractor(IProductosRepository repository, IObtenerProductoPresentador presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(int idProduct)
        {
            WrapperObtenerProducto productoresponse = new();

            try
            {
                var existingProduct = await _repository.obtenerporId(idProduct);
                if (existingProduct != null)
                {
                    productoresponse.IdProducto = existingProduct.Id;
                    productoresponse.Nombre = existingProduct.Nombre;
                }
                else
                {
                    productoresponse.NumeroError = 404;
                    productoresponse.Mensaje = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                productoresponse.Mensaje = ex.Message;

            }
            finally
            {
                await _presenter.Handle(productoresponse);
            }
        }
    }
}
