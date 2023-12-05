using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos
{
    public interface IBorrarProductoControlador
    {
        Task<WrapperBorrarProducto> BorrarProducto(int IdProducto);
    }
}
