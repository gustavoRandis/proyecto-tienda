using Tiendita.Entity.Common;

namespace reglasdenegocio.Entidades
{
    public class Chat : Entitycommon
    {
        //ESTA ENTIDAD REPRESENTA AL CHAT DONDE LAS PERSONAS ESCRIBIRAN SUS CONSULTAS
        //SOBRE LOS PRODUCTOS Y LAS RESPUESATS DE LOS VENDEDORES    
        public int PreguntadoPor { get; set; }
        public int RespondidoPor { get; set;}
        public string Pregunta { get; set;}
        public string Respuesta { get;}

        public DateTime fecha_msj { get; set;}
        public DateTime fecha_resp { get; set;}

        
    }
}
