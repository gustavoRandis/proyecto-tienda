using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IPago:IUnitOfWork<Pago>
    {
        Task<Pago> obtenerporId(int Id);
        Task<List<Pago>> obtenerTodoslosPagos();
    }
}
