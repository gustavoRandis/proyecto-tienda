using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace VideoClub.BusinessRules.Wrappers.Actor
{
    public class ActualziarPublicacion : BaseWrappers
    {
        public int IdPublicacion { get; set; }
        public string NombrePublicacion { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
