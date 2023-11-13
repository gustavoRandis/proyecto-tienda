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
    //La clase encapsula la lógica para manejar la creación de productos, incluida la validación y la interacción con el repositorio
    //de productos(IProductosRepository) y el presentador(ICrearProductoPresentador)
    /// <summary>
    /// Clase que implementa el Input Port para crear un ProductoResponse.
    /// </summary>
    public class CrearProductoIteractor : ICrearProductoInputPort
    {
        readonly IProductosRepository _repository;
        readonly ICrearProductoPresentador _presenter;

        /// <summary>
        /// Constructor de la clase CreateActorIteractor.
        /// </summary>
        /// <param name="repository">El repositorio de productos.</param>
        /// <param name="presenter">El presentador para la creación de produtos.</param>
        public CrearProductoIteractor(IProductosRepository repository, ICrearProductoPresentador presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        /// <summary>
        /// Maneja la creación de un nuevo actorResponse.
        /// </summary>
        /// <param name="createActorRequest">Los datos para crear el actorResponse.</param>
        /// <returns>El ID del nuevo actorResponse creado o 0 si hubo errores.</returns>
        public async Task Handle(CrearProductoDTO crearProductoDTO)
        {
            List<ValidacionErroresDTO> errors = new List<ValidacionErroresDTO>();
            errors = ValidateActor(crearProductoDTO);
            WrapperCrearProducto productoResponse = new();

            if (errors.Any())
            {
                productoResponse.ValidacionErrores = errors;
                await _presenter.Handle(productoResponse);
                return;
            }

            Producto newProducto = new()
            {
                Nombre = crearProductoDTO.nombre
            };

            try
            {
                await _repository.Create(newProducto);
                await _repository.GuardarCambios();
                productoResponse.IdProducto = newProducto.Id;
            }
            catch (Exception ex)
            {
                productoResponse.NumeroError = 500;
                productoResponse.Mensaje = $"Se produjo un error al guardar los datos. {ex.Message}";
            }
            finally
            {
                await _presenter.Handle(productoResponse);
            }
        }

        private List<ValidacionErroresDTO> ValidateActor(CrearProductoDTO crearProductoDTO)
        {
            var specification = new CrearProductoEspecificacion(crearProductoDTO);
            return specification.IsValid();
        }
    }
}
