using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Interfaces.EspecificaciondeValidacion
{
    public interface IEspecificacion<T> where T :class
    {
        List<ValidacionErroresDTO> isvalida();
    }
}
