
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente
{
    public interface IBorrarClienteController
    {
        Task<CrearBorrarClienteWRP> BorrarCliente(int IdCliente);
    }
}
