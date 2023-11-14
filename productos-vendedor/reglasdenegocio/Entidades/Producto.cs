using Tiendita.Entity.Common;
using Tiendita.Entity.Enums;

namespace reglasdenegocio.Entidades
{
    public class Producto: Entitycommon
    {
        //CONTIENE LAS  PROPIEDADES QUE TENDRAN LOS PRODUCTOS
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public short Cant_producto { get; set; }
        public string identificador { get; set; }
        /*preguntarle al marten si dentro de la interfaz producto, no debriamos tener la propiedad categoria.*/
    }
}
