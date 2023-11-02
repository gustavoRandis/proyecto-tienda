
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Vendedor
{
    public class WrapperCrearVendedor : BaseWrapper
    {
        public int IdVendedor { get; set; }
        public List<ValidacionErroresDTO>? ValidacionErrores { get; set; }
    }
}
