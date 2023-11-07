using System.Security;

namespace Tiendita.ReglasdeNegocio.DTOs.ImagenDTOs
{
    public class CargarImagenDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int NumDocumento { get; set; }
        public SecureString Contrasena { get; set; }

    }
}
