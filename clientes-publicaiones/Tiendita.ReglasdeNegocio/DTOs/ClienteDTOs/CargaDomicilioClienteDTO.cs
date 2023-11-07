using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs
{
    public class CargaDomicilioClienteDTO
    {
        public string Calle { get; set; }
        public short Num_calle { get; set; }
        public short NumDepartamento { get; set; }
        public string InformacionAdicional { get; set; }
    }
}
