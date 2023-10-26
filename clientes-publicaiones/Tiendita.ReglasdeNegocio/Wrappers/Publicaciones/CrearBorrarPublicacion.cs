using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace VideoClub.BusinessRules.Wrappers.Actor
{
    public class CrearBorrarPublicacion : BaseWrappers
    {
        public int IdPublicacion { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
