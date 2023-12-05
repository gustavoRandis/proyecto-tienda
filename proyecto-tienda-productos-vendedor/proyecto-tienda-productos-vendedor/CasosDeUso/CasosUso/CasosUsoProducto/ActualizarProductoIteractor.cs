using CasosDeUso.Especificaciones.EspecificacionesProductos;
using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace CasosDeUso.CasosUso.CasosUsoProducto
{
    public class ActualizarProductoIteractor : IActualizarProductoInputPort
    {
        private readonly IProductosRepository _repository;
        private readonly IActualizarProductoPresentador _presenter;

        public ActualizarProductoIteractor (IProductosRepository repository, IActualizarProductoPresentador presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(ActualizacionProductoDTO actualizacionProductoDTO)
        {
            List<ValidacionErroresDTO> errors = new List<ValidacionErroresDTO>();
            WrapperActualizarProducto productoresponse = new();

            try
            {
                //Valida los datos del actorResponse a actualizar.
                errors = ValidateProduct(actualizacionProductoDTO);

                if (errors.Any())
                {
                    // Manejar el caso en el que el actorResponse no cumpla con las validaciones.
                    // Devuelve un mensaje indicando que los datos del actorResponse no son validos.
                    productoresponse.ValidacionErrores = errors;
                    await _presenter.Handle(productoresponse);
                    return;
                }

                // Obtener el actorResponse existente por su ID
                Producto existingProduct = await _repository.obtenerporId(actualizacionProductoDTO.IdProducto);
                if (existingProduct == null)
                {
                    // Manejar el caso en el que el actorResponse no existe
                    // Devuelve un mensaje indicando que el actorResponse no se encontró.
                    productoresponse.NumeroError = 404;
                    productoresponse.Mensaje = $"El producto con {actualizacionProductoDTO.IdProducto} no existe";
                    await _presenter.Handle(productoresponse);
                    return;
                }

                // Actualizar la información del actorResponse con los datos proporcionados
                existingProduct.Nombre = actualizacionProductoDTO.Nombre;

                // Realizar la actualización en el repositorio
                await _repository.Update(existingProduct);
                await _repository.GuardarCambios();

                // Crear un objeto de respuesta exitosa
                productoresponse.IdProducto = existingProduct.Id;
                productoresponse.Nombre = existingProduct.Nombre;

                // Enviar la respuesta al presentador
                await _presenter.Handle(productoresponse);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                productoresponse.Mensaje = ex.Message;
            }
            finally
            {
                await _presenter.Handle(productoresponse);
            }
        }

        private List<ValidacionErroresDTO> ValidateProduct(ActualizacionProductoDTO actualizacionProductoDTO)
        {
            var specification = new ActualizarProductoEspecificaciones(actualizacionProductoDTO);
            return specification.IsValid();
        }
    }
}
