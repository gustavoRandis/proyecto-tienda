using System.Security;

namespace Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs
{
    public class ActualizarCliente
    {
        public string? Nombre { get; set; }
        public string Correo { get; set; }
        public SecureString Contrasena { get; set; }

    }
}
