using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace VideoClub.BusinessRules.Wrappers.Actor
{
    public class CrearBorrarCliente : BaseWrappers
    {
        public int IdCliente { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
