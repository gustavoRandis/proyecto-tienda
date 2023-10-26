using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IClienteRepository:IUnitOfWork<Cliente>
    {

        Task BuscarPor(int id);     
        Task<List<Cliente>> obtenerTodoslosClientes();

    }
}
