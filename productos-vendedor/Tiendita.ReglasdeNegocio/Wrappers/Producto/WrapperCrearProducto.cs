
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Producto
{
    public class WrapperCrearProducto : BaseWrapper
    {

        public int IdProducto { get; set; }
        public List<ValidacionErroresDTO>? ValidacionErrores { get; set; }
    }
}
