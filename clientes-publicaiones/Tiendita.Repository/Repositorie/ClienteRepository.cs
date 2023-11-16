using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using reglasdenegocio.Entidades;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.PersonalException;
using Tiendita.Repository.Contexto;
namespace Tiendita.Repository.Repositorie
{
    public class ClienteRepository : IClienteRepository
    {
        readonly TienditaContexto _context;

        public ClienteRepository(TienditaContexto context)
        {
            _context = context;
        }

        public async Task Crear(Cliente cliente)
        {
            try
            {
                await _context.AddAsync(cliente);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }
        public async Task Borrar(int IdCliente)
        {
            try
            {
                var result = await _context.clientes.FirstOrDefaultAsync(a => a.Id == IdCliente && a.IsDeleted == false);
                if (result != null)
                {
                    result.IsDeleted = true;
                }
                else
                {
                    throw new DBMySqlException(404, "El registro no fue encontrado");
                }
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }
        public async Task<Cliente> BuscarPor(int idcliente)
        {
            try
            {
                Cliente result = new Cliente();
                result = await _context.clientes.FirstOrDefaultAsync(a => a.Id == idcliente && a.IsDeleted == false);
                return result;

            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task GuardarCambios()
        {
            await _context.SaveChangesAsync();
        }
    }
}
