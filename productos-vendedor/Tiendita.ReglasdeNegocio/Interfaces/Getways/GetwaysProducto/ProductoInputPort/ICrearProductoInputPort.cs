using Tiendita.ReglasdeNegocio.DTOs.productosDTO;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort
{
    /// <summary>
    /// Este Input Port se encarga de manejar la creación de un nuevo producto en el sistema. 
    /// </summary>
    public interface ICrearProductoInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CreateActorRequest con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="Crearproducto">Contiene los detalles del nuevo producto a crear.</param>
        Task Handle(CrearProductoDTO Crearproducto);
    }
}
