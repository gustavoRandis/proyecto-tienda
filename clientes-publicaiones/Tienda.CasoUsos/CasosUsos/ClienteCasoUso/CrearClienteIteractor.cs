using reglasdenegocio.Entidades;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;
using Tienda.CasoUsos.Especificaciones.Cliente;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.PersonalException;




namespace Tienda.CasoUsos.CasosUsos.ClienteCasoUso
{
    internal class CrearClienteIteractor : ICrearClienteInputPort
    {
        readonly ClienteRepository _repository;
        readonly ICrearClientePresenter _presenter;
        public CrearClienteIteractor(ClienteRepository repository, ICrearClientePresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(CrearClienteDTO crearClienteDTO)
        {
            List<ValidacionErroresDTO> errors = new List<ValidacionErroresDTO>();
            errors = ValidarCliente(crearClienteDTO);
            CrearBorrarClienteWRP ClienteRespuesta = new();

            if (errors.Any())
            {
                ClienteRespuesta.ValidationErrors = errors;
                await _presenter.Handle(ClienteRespuesta);
                return;
            }
           


            Cliente newCliente = new()
            {
                Nombre = crearClienteDTO.Nombre
            };

            try
            {
                await _repository.Crear(newCliente);
                await _repository.GuardarCambios();
                ClienteRespuesta.IdCliente = newCliente.Id;
            }
            catch (DBMySqlException ex)
            {
                ClienteRespuesta.NumeroError = ex.Number;
                ClienteRespuesta.MensajeError = ex.MessageError;
            }
            finally
            {
                await _presenter.Handle(ClienteRespuesta);
            }

        }
            private List<ValidacionErroresDTO> ValidarCliente(CrearClienteDTO crearClienteDTO)
            {
                var specification = new CrearClienteEspecificaciones(crearClienteDTO);
                return specification.Validar();
            }
            
    }
}





  