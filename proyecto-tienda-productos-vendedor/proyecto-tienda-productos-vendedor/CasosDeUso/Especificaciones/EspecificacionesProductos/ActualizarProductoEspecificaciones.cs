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
    public class ActualizarProductoEspecificaciones : IEspecificacion<ActualizacionProductoDTO>
    {
        readonly ActualizacionProductoDTO _entity;
        readonly List<ValidacionErroresDTO> _errors = new List<ValidacionErroresDTO>();

        public ActualizarProductoEspecificaciones(ActualizacionProductoDTO entity)
        {
            _entity = entity;
        }

        public List<ValidacionErroresDTO> IsValid()
        {
            if (_entity.IdProducto == 0)
            {
                _errors.Add(new ValidacionErroresDTO()
                {
                    NombrePropiedad = "Id",
                    MensajeError = "Debe especficar el Id que desea actualizar"
                });
            }

            if (string.IsNullOrEmpty(_entity.Nombre))
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Nomre Actor",
                    MensajeError = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.Nombre) && _entity.Nombre.Length > 45)
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Nomre Actor",
                    MensajeError = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
