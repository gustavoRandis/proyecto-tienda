using System.Transactions;
using Tiendita.Entity.Common;
using Tiendita.Entity.Enums;

namespace reglasdenegocio.Entidades
{
    public class Pago:Entitycommon
    {
        public int IdPedido { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public int total {  get; set; }
        public string estado {  get; set; }


    }
}
