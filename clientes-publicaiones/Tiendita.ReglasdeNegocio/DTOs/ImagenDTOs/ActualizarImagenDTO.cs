using System.Security;

namespace Tiendita.ReglasdeNegocio.DTOs.ImagenDTOs
{
    public class ActualizarImagenDTO
    {
        public string Nombre { get; set; }
        public SecureString Contrasena { get; set; }

        //Actualizacion Algun Apartado de domicilio
        public string? Calle { get; set; }
        public short? Num_calle { get; set; }
        public short? NumDepartamento { get; set; }
        public string? InformacionAdicional { get; set; }

    }
}
