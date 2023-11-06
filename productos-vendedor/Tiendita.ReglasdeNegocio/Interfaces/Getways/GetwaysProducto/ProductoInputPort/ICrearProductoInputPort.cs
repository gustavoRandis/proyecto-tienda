using Tiendita.ReglasdeNegocio.DTOs.productosDTO;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort
{
    /// <summary>
    /// Este Input Port se encarga de manejar la creación de un nuevo actor en el sistema. 
    /// </summary>
    public interface ICrearProductoInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CreateActorRequest con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="creatActorRequest">Contiene los detalles del nuevo actor a crear.</param>
        Task Handle(ProductoDTO Crearproducto);
    }
}
