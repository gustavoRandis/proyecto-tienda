using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace VideoClub.BusinessRules.Wrappers.Actor
{
    public class ActualizarClientes : BaseWrappers
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
