using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface ActualizarPublicacionController
    {
        Task<ActualziarPublicacionWrapper> ActualizarPublicacion(ActualizarPublicacion request);
    }
}
