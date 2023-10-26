using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IPublicacionRepository : IUnitOfWork<Publicaciones>
    {
        Task BuscarPor(int id);
        Task<List<Publicaciones>> obtenerTodoslasPublicaciones();
        Task<List<Publicaciones>> ObtenerPublicacionesPorVendedor(int id);

    }
}
