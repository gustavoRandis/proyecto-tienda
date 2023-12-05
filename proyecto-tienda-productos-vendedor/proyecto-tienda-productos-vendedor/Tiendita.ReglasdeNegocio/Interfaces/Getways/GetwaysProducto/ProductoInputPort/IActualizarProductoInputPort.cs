using Tiendita.ReglasdeNegocio.DTOs.productosDTO;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort
{
    public interface IActualizarProductoInputPort
    {
        /// <summary>
        /// El método Handle recibe un objeto UpdateActorRequest con información para
        /// actualizar en elcontexto.
        /// </summary>
        /// <param name="updateActorRequest">Contiene los detalles actualizados del actor,
        /// incluido el Id del actor que se debe actualizar.</param>
        Task Handle(ActualizacionProductoDTO actualizacionProducto);
    }

}
