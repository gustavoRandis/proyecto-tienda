using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.DTOs.productosDTO
{
    // Este DTO encapsula la información necesaria para crear un producto en el sistema. 
    public class CrearProductoDTO
    {
        public string Nombre { get; set; } // Nombre en la base de datos: 'Nombre'
        public string Descripcion { get; set; } // Descripcion en la base de datos: 'Descripcion'
        public string Cant_producto { get; set; } // Cant_producto en la base de datos: 'Cant_producto'
        public string Identificador { get; set; } // Identificador en la base de datos: 'Identificador'
        public DateTime FechaCreacion { get; set; } // FechaCreacion en la base de datos: 'FechaCreacion'
        public DateTime FechaActualizacion { get; set; } // FechaActualizacion en la base de datos: 'FechaActualizacion'

    }
}
