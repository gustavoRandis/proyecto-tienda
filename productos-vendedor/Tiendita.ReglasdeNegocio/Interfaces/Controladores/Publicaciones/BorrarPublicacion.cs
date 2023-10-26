using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones
{
    internal interface CrearPublicacion
    {
        Task<PublicacionRespuesta> BorrarPublicacion(int IdPublicacion);
    }
}
