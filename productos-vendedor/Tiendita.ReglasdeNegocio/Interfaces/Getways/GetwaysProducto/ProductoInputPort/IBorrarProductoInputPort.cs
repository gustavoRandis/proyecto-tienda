namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort
{

    public interface IBorrarProductoInputPort
    {
        Task Handle(int IdProducto);
    }

}
