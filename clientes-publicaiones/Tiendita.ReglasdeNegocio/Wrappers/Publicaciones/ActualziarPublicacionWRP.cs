using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Publicaciones
{
    public class ActualziarPublicacionWRP : BaseWrappers
    {
        public int IdPublicacion { get; set; }
        public string NombrePublicacion { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
