namespace Tiendita.Entity.Common
{
    public class Entitycommon
    {
        //es una clase que proporciona propiedades que son comunes en determinadas clases que heredaran de de esta clase
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

    }
}
  