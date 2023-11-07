using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.PublicacionPresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;
using VideoClub.BusinessRules.Interfaces.Getways.PublicacionGetways.InputPorts;

namespace Tiendita.Controllers.PublicacionController
{
    internal class CrearPublicacionController : ICrearPublicacionController
    {
         
        readonly ICrearPublicacionInputPort _inputPort;
        readonly ICrearPublicacionPresenter _presenter;

        public CrearPublicacionController(ICrearPublicacionInputPort inputPort, ICrearPublicacionPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }
        public async Task<CrearBorrarPublicacionWRP> CrearPublicacion(CrearPublicacionDTO request)
        {
            await _inputPort.Handle(request);
            return _presenter.Publicacion;
        }
            
        }
}
