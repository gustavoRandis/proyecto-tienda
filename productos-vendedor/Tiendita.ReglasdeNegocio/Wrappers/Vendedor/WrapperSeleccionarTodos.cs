using Tiendita.ReglasdeNegocio.DTOs.VendedorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Vendedor
{

    public class WrapperSeleccionarTodos : BaseWrapper
    {
        public List<vendedor>? Vendedor { get; set; } = new List<vendedor>();

    }
}


