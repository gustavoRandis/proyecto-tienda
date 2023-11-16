using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.ExcepcionesPersonales;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

//Basicamente lo que hace esta clase es que se utiliza para implementar la lógica del caso de uso que busca obtener todos
//los productos de el repositorio repositorio y presentar los resultados a través de un presentador.

namespace CasosDeUso.CasosUso.CasosUsoProducto
{
    public class ObtenerTodosProductosIteractor : IObtenerTodosProductosInputPort
    {
        private readonly IProductosRepository _repository;
        private readonly IObtenerTodosProductosPresentador _presenter;

        public ObtenerTodosProductosIteractor(IProductosRepository repository, IObtenerTodosProductosPresentador presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async ValueTask Handle()
        {
            WrapperObtenerTodosProductos productoResponse = new();
            try
            {
                var existingProducts = await _repository.obtenerTodoslosProductos();

                if (existingProducts != null && existingProducts.Count > 0)
                {
                    foreach (var producto in existingProducts)
                    {
                        productoResponse.Producto.Add(new ProductoResponseDTO
                        {
                            idProducto = producto.Id,
                            nombre = producto.Nombre
                        });
                    }
                }

                else
                {
                    productoResponse.NumeroError = 404;
                    productoResponse.Mensaje = "No existen registros en la tabla Productos.";
                }

            }
            catch (DBMySqlException ex)
            {
                productoResponse.NumeroError = ex.Number;
                productoResponse.Mensaje = ex.MessageError;

            }
            finally
            {
                await _presenter.Handle(productoResponse);
            }
        }
    }
}
