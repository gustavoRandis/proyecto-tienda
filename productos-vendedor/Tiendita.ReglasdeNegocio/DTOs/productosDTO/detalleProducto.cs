using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.DTOs.productosDTO
{
    public class detalleProducto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
        public List<string> Imagenes { get; set; }
    }
}
