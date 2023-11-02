using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.VendedorDTO;
using Tiendita.ReglasdeNegocio.Wrappers.Vendedor;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresVendedor
{
    internal interface IModificarVendedor
    {
        Task<WrapperActualizarVendedor> ActualizarVendedor(actualizarVendedor requerimiento);
    }
}
