namespace Tiendita.ReglasdeNegocio.Wrappers.Cliente
{

    public class TraerTodosClientesWRP : BaseWrappers
    {
        public List<Cliente>? Clientes { get; set; } = new List<Cliente>();

        public class Cliente
        {
            public int IdCliente { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            public string NombreCliente { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        }
    }
}


