using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface ObtenerUnaPublicacionController
    {
        Task<SeleccionarPublicacionWrapper> TraerPublicacion(int IdPublicacion);
    }
}
