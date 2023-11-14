using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    //define métodos para interactuar con pagos, permitiendo obtener pagos por ID y listar todos los pagos.
    public interface IPago:IUnitOfWork<Pago>
    {
        Task<Pago> obtenerporId(int Id);
        Task<List<Pago>> obtenerTodoslosPagos();
    }
}
