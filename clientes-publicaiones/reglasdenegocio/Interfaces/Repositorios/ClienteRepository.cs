using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface ClienteRepository
    {

        Task BuscarPor(int id);
        Task Crear(Cliente cliente);
        Task Borrar(int id);
        Task Modificar(Cliente cliente);
        Task GuardarCambios();

        Task<List<Cliente>> TraerTodosLosClientes();

    }
}
