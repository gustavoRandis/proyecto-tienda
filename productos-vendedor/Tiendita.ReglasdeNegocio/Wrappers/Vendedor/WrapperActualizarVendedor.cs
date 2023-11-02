

using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Vendedor
{
    public class WrapperActualizarVendedor : BaseWrapper
    {
        public int IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public List<ValidacionErroresDTO>? ValidacionErrores { get; set; }
    }
}
