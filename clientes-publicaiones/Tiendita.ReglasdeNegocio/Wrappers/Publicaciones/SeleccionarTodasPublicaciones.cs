namespace VideoClub.BusinessRules.Wrappers.Actor
{

    public class SeleccionarTodasPublicaciones : BaseWrappers
    {
        public List<Publicacion>? Publicaciones { get; set; } = new List<Publicacion>();

        public class Publicacion
        {
            public int IdPublicacion { get; set; }
            public string NombrePublicacion { get; set; }
        }
    }
}


