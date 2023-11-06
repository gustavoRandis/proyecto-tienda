using Tiendita.Entity.Enums;

namespace reglasdenegocio.Entidades
{
    public class Cliente : Usuariocommon
    {

        //ESTA CLASE SE REFIERE A LOS DISTINTOS CLIENTES QUE ESTARAN REGISTRADOS EN NUESTRO SITIO
        public string? Calle { get; set; }
        public short? Num_calle { get; set; }
        public short? NumDepartamento { get; set; }
        public string? InformacionAdicional { get; set; }
        public MetodoPago? MetodoPago { get; set; }
    }
}
