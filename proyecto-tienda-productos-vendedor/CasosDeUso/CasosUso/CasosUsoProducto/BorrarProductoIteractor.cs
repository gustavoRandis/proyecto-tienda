//using Tiendita.Entity.Interfaces.Repositorios;
//using Tiendita.ReglasdeNegocio.ExcepcionesPersonales;
//using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort;
//using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
//using Tiendita.ReglasdeNegocio.Wrappers.Producto;

//namespace CasosDeUso.CasosUso.CasosUsoProducto
//{
//    public class BorrarProductoIteractor : IBorrarProductoInputPort
//    {
//        private readonly IProductosRepository _repository;
//        private readonly IBorrarProductoPresentador _presenter;

//        public BorrarProductoIteractor(IProductosRepository repository, IBorrarProductoPresentador presenter)
//        {
//            _repository = repository;
//            _presenter = presenter;
//        }

//        public async Task Handle(int idproducto)
//        {

//            WrapperBorrarProducto productoResponse = new();
//            try
//            {
//                // Eliminar el producto
//                await _repository.Delete(idproducto);
//                await _repository.GuardarCambios();
//                productoResponse.IdProducto = idproducto;
//            }
//            catch (DBMySqlException ex)
//            {
//                // Manejar errores
//                productoResponse.NumeroError = ex.Number;
//                productoResponse.Mensaje = ex.MessageError;
//            }
//            finally
//            {
//                // Notificar al presentador que se eliminó el actor.
//                await _presenter.handle(productoResponse);
//            }

//        }
//    }
//}