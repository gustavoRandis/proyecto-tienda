using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos
{
    public interface IBorrarProducto
    {
        Task<WrapperBorrarProducto> BorrarProducto(int IdProducto);
    }
}
