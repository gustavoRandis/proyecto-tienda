using Tiendita.ReglasdeNegocio.DTOs.VendedorDTO;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysVendedor.VendedorInputPort
{
    public interface IActualizarVendedorInputPort
    {
        /// <summary>
        /// El método Handle recibe un objeto UpdateActorRequest con información para
        /// actualizar en elcontexto.
        /// </summary>
        /// <param name="actualizacionVendedor">Contiene los detalles actualizados del vendedor,
        /// incluido el Id del actor que se debe actualizar.</param>
        Task Handle(actualizarVendedor actualizacionVendedor);
    }

}
