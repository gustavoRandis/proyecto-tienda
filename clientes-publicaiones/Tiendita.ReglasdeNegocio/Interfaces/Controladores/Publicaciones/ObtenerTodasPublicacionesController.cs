using VideoClub.BusinessRules.Wrappers.Actor;

namespace VideoClub.BusinessRules.Interfaces.Controllers.ActorControllers
{
    public interface ObtenerTodasPublicacionesController
    {
        ValueTask<SeleccionarTodasPublicacionesWrapper> TraerPublicaicones();
    }
}
