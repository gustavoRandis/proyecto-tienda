using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Wrappers.Imagen;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Imagen
{
    public interface ITraerImagen
    {
        Task<TraerImagenWRP> TraerImagen(int IdCliente);
    }
}
