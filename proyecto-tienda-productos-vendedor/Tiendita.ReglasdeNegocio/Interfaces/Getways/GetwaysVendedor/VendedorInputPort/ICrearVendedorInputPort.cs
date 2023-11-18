using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.DTOs.VendedorDTO;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysVendedor.VendedorInputPort
{
    /// <summary>
    /// Este Input Port se encarga de manejar la creación de un nuevo actor en el sistema. 
    /// </summary>
    public interface ICrearVendedorInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CreateActorRequest con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="Crearvendedor">Contiene los detalles del nuevo vendedor a crear.</param>
        Task Handle(vendedor Crearvendedor);
    }
}
