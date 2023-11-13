using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.EspecificaciondeValidacion;

namespace CasosDeUso.Especificaciones.EspecificacionesProductos
{
    public class CrearProductoEspecificacion : IEspecificacion<CrearProductoDTO>
    {
        readonly CrearProductoDTO _entity;
        readonly List<ValidacionErroresDTO> _errors = new List<ValidacionErroresDTO>();
        public CrearProductoEspecificacion(CrearProductoDTO entity)
        {
            this._entity = entity;
        }

        public List<ValidacionErroresDTO> IsValid()
        {
            if (string.IsNullOrEmpty(_entity.nombre))
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Nomre Producto",
                    MensajeError = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.nombre.Length > 45)
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Nomre Producto",
                    MensajeError = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
