using Tiendita.Entity.Common;

namespace reglasdenegocio.Entidades
{
    public class Publicaciones : Entitycommon
    {
        public short NombrePublicacion { get; set; }
        public int Producto { get; set; }
        public short DescripcionPorducto { get; set; }
        public int CreadoPor { get; set; }
        public int? ActualizadoPor { get; set; }
        public short CantProductos { get; set; }

    }
}
