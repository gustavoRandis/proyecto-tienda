using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IProductosRepository : IUnitOfWork<Producto>
    {
        Task<Producto> obtenerporId(int Id);
        Task<List<Producto>> obtenerTodoslosProductos();
    }
}
/*preguntarle al chango si dentro de la interfaz producto, no debriamos tener la propiedad categoria.*/