using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IPedido:IUnitOfWork<Pedido>
    {
        Task<Pedido> obtenerporId(int Id);
        Task<List<Pedido>> obtenerTodoslosPedidos();
    }
}
