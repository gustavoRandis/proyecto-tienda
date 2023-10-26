namespace VideoClub.BusinessRules.Wrappers.Actor
{

    public class SeleccionarTodosClientes : BaseWrappers
    {
        public List<Cliente>? Clientes { get; set; } = new List<Cliente>();

        public class Cliente
        {
            public int IdCliente { get; set; }
            public string NombreCliente { get; set; }
        }
    }
}


