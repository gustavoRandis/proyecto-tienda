

using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Producto
{
    public class WrapperActualizarProducto : BaseWrapper
    {
        public int IdProductor { get; set; }
        public string NombreProducto { get; set; }
        public List<ValidacionErroresDTO>? ValidacionErrores { get; set; }
    }
}
