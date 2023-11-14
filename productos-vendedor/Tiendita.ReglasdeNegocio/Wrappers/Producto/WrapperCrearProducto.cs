
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Producto
{
    //es un contenedor que encapsula la información relacionada con la creación de productos
    public class WrapperCrearProducto : BaseWrapper
    {

        public int IdProducto { get; set; }
        public List<ValidacionErroresDTO>? ValidacionErrores { get; set; }
    }
}
