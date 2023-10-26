using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones
{
    public interface CrearPublicacion
    {
        Task<PublicacionRespuesta> BorrarPublicacion(int IdPublicacion);
    }
}
