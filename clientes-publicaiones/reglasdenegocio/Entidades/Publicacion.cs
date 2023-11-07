using System.Reflection.Metadata;
using Tiendita.Entity.Common;
using Tiendita.Entity.Entidades;

namespace reglasdenegocio.Entidades
{
    public class Publicacion : Entitycommon
    {
        public string NombrePublicacion { get; set; }
        public int Producto { get; set; }
        public short DescripcionPorducto { get; set; }
        public int CreadoPor { get; set; }
        public int? ActualizadoPor { get; set; }
        public short CantProductos { get; set; }
        public List<Imagen> imagenes { get; set; }

    }
}
