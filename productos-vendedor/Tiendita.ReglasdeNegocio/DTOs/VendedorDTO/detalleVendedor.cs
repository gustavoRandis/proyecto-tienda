using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.DTOs.VendedorDTO
{
    public class detalleVendedor
    {
        public int idVendedor { get; set; }
        public string nombreVendedor { get; set; }
        public string apellidoVendedor { get; set; }
        public string correoVendedor { get; set; }
        public int telefonoVendedor { get; set; }
        /*pregutarle al chango si en la entidad vendedor como entidad no deberia tener publicaciones*/
    }
}
