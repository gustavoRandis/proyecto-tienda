namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysVendedor.VendedorInputPort
{

    public interface IBorrarVendedorInputPort
    {
        Task Handle(int IdVendedor);
    }

}
