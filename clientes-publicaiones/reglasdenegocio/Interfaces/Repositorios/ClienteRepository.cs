using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface ClienteRepository
    {

        Task BuscarPor(int id);
        Task DarDeAlta(Cliente cliente);
        Task DarDeBaja(int id);
        Task Modificar(Cliente cliente);
        Task GuardarCambios();

        Task<List<Cliente>> TraerTodosLosClientes();

    }
}
