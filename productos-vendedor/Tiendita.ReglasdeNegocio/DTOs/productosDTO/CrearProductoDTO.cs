using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.DTOs.productosDTO
{
    public class CrearProductoDTO
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
    }
}   