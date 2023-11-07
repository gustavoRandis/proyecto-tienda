using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface CrearPublicaionController
    {
        Task<CrearBorrarPublicacionWrapper> CrearPublicacion(CracionPublicacion request);
    }
}
