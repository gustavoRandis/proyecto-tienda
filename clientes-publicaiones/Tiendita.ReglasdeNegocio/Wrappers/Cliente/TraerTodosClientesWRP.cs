namespace Tiendita.ReglasdeNegocio.Wrappers.Cliente
{

    public class TraerTodosClientesWRP : BaseWrappers
    {
        public List<Cliente>? Clientes { get; set; } = new List<Cliente>();

        public class Cliente
        {
            public int IdCliente { get; set; }
            public string NombreCliente { get; set; }
        }
    }
}


