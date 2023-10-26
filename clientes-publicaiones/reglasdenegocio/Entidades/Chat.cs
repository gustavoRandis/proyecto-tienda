using Tiendita.Entity.Common;

namespace reglasdenegocio.Entidades
{
    public class Chat : Entitycommon
    {

        public int PreguntadoPor { get; set; }
        public int RespondidoPor { get; set;}
        public string Pregunta { get; set;}
        public string Respuesta { get;}

        public DateTime fecha_msj { get; set;}
        public DateTime fecha_resp { get; set;}

        
    }
}
