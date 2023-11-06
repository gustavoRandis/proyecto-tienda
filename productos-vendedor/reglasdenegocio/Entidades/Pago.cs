using System.Transactions;
using Tiendita.Entity.Common;
using Tiendita.Entity.Enums;

namespace reglasdenegocio.Entidades
{
    public class Pago:Entitycommon
    {
        //ESTA ENTIDAD REPRESENTA LOS PAGOS QUE AHRAN LOS CLIENTES TIENE EL ENUM METODO DE PAGO, PORQUE 
        //SE ADMITIRAN MAS DE UN METODO DE PAGO
        public int IdPedido { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public int total {  get; set; }
        public string estado {  get; set; }


    }
}
