

using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Producto
{
    public class WrapperActualizarProducto : BaseWrapper
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public List<ValidacionErroresDTO>? ValidacionErrores { get; set; }
    }
}
