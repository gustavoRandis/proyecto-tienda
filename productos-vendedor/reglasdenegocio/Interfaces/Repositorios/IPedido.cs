using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    //Esta interfaz define métodos para interactuar con pedidos, permitiendo obtener pedidos por ID y listar todos los pedidos.
    public interface IPedido:IUnitOfWork<Pedido>
    {
        Task<Pedido> obtenerporId(int Id);
        Task<List<Pedido>> obtenerTodoslosPedidos();
    }
}
