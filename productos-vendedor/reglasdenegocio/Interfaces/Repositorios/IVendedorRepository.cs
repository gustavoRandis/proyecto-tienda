using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{

    //Esta interfaz IVendedorRepository define métodos para interactuar con vendedores
    public interface IVendedorRepository : IUnitOfWork<Vendedor>
    {
        Task<Vendedor> obtenerporId(int Id);
        Task<List<Vendedor>> obtenerTodoslosVendedores();
    }
}
