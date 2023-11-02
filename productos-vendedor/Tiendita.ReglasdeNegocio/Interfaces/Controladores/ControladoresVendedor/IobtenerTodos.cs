using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Wrappers.Vendedor;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresVendedor
{
    public interface IobtenerTodos
    {
        ValueTask<WrapperSeleccionarTodos> ObtenerrTodos();
    }
}
