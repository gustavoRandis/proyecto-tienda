

using Tiendita.ReglasdeNegocio.DTOs.productosDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Producto
{
    public class WrapperObtenerProducto : BaseWrapper
    {
        public int IdProducto {  get; set; }
        public string? Nombre { get; set; }
    }
}
