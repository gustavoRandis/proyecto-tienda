using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Interfaces.Repositorios;

namespace Tiendita.Repositorio.Repositorio
{
    public class ProductoRepositorio : IProductosRepository
    {
        readonly TienditaContext _context;

        public ProductoRepositorio(Tienditacontext context)
        {
            _context = context;
        }

        public async Task Create(producto producto)
        {
            try
            {
                await _context.AddAsync(producto);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task Delete(int productoId)
        {
            try
            {
                var result = await _context.Productos.FirstOrDefaultAsync(a => a.Id == productoId && a.IsDeleted == false);
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

        public async Task<List<ProductoRepositorio>> GetAllProducts()
        {
            try
            {
                List<Produto> result = new List<producto>();
                result = await _context.Actors.Where(a => a.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<producto> GetById(int actorId)
        {
            try
            {
                Producto result = new Producto();
                result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == productoId && a.IsDeleted == false);
                return result;

            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
