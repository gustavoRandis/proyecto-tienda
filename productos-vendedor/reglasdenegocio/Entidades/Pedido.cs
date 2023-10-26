using Tiendita.Entity.Enums;

namespace reglasdenegocio.Entidades
{
    public class Pedido : Usuariocommon
    {

        //DIRECCION
        public string Calle { get; set; }
        public short Numero { get; set; }
        public short NumDepartamento { get; set; }
        public short AlturaCalle { get; set;}
        public string InformacionAdicional { get; set; }
        public MetodoPago MetodoPago { get; set; }
    }
}
