using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace VideoClub.BusinessRules.Wrappers.Actor
{
    public class ActualziarPublicacionWrapper : BaseWrappers
    {
        public int IdPublicacion { get; set; }
        public string NombrePublicacion { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
