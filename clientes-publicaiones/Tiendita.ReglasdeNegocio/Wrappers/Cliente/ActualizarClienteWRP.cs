using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Cliente
{
    public class ActualizarClienteWRP : BaseWrappers
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
