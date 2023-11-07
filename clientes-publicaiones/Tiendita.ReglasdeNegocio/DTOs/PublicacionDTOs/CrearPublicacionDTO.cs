using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs
{
    public class CrearPublicacionDTO
    {
         
        public string NombrePublicacion { get; set;}
        public int? Producto { get; set; }
        public string DescripcionPorducto { get; set;}
        public short CantProductos { get; set; }
        public string? ImagenURL { get; set; }
    
    }
}
