using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface PublicacionRepository
    {
        Task BuscarPor(int id);
        Task DarDeAlta(Publicaciones publicacion);
        Task DarDeBaja(int id);
        Task Modificar(Publicaciones publicacion);
        Task GuardarCambios();
        Task<List<Publicaciones>> TraerTodasLasPublicaciones();
    }
}
