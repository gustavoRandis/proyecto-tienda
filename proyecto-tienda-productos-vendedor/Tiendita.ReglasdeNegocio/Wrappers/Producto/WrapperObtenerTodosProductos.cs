using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.DTOs.VendedorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Producto
{

    public class WrapperObtenerTodosProductos : BaseWrapper
    {
        public List<ProductoResponseDTO>? Producto { get; set; } = new List<ProductoResponseDTO>();

    }
}


