using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IClienteRepository
    {
        Task<Cliente> BuscarPor(int IdCliente);
        Task Crear(Cliente cliente);
        Task Borrar(int IdCliente);
        //Task Modificar(Cliente cliente);


        //Task<List<Cliente>> TraerTodosLosClientes();
        Task GuardarCambios();  
    }
}
