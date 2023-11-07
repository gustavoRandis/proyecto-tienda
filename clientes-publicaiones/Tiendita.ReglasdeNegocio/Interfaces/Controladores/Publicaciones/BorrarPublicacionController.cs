using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface BorrarPublicacionController
    {
        Task<CrearBorrarPublicacionWrapper> BorrarPublicacion(int IdPublicacion);
    }
}
