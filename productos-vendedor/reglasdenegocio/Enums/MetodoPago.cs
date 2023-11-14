using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Enums
{
    //Este enumerado representa los métodos de pago posibles
    public enum MetodoPago
    {
        Tarjeta,
        TransferenciaBancaria,
        PagoFacil,
        RapiPago,
    }
}
