using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones
{
    public interface ITraerPublicacionIdController
    {
        Task<TraerPublicacionWRP> TraerPublicacion(int IdPublicacion);
    }
}
