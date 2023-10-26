using Tiendita.Entity.Enums;

public class Usuariocommon
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public int NumDocumento { get; set; }
    public SecureString Contrasena { get; set; }

    //DIRECCION :
    public Provincias Provincia { get; set; }
    public string CodigoPostal { get; set; }
    public string Telefono { get; set; }

    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime? FechaActualizacion { get; set; } = DateTime.Now;
}

