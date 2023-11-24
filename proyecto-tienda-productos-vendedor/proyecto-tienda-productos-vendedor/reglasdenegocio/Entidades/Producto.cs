using Tiendita.Entity.Common;
using Tiendita.Entity.Enums;

namespace reglasdenegocio.Entidades
{
    public class Producto: Entitycommon
    {
        //CONTIENE LAS  PROPIEDADES QUE TENDRAN LOS PRODUCTOS
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cant_producto { get; set; }
        public int Identificador { get; set; }
        /*preguntarle al marten si dentro de la interfaz producto, no debriamos tener la propiedad categoria.*/
    }
}
