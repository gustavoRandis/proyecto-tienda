using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos
{
    //esta interfaz proporciona un contrato para la creación de productos, permitiendo que las implementaciones concretas
    //de este interfaz manejen la lógica específica de creación y devuelvan los resultados o errores correspondientes.
    public interface ICrearProducto
    {
        Task<WrapperCrearProducto> CrearProducto(CrearProductoDTO request);
    }
}
