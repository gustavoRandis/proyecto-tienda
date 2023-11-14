using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Interfaces.EspecificaciondeValidacion
{
    //Las clases concretas que implementan esta interfaz deben proporcionar la lógica de validación específica para el tipo
    //particular de entidad o DTO que están validando.
    public interface IEspecificacion<T> where T :class
    {
        List<ValidacionErroresDTO> IsValid();
    }
}
