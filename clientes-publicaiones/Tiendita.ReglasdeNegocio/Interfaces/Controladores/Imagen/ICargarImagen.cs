using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.ImagenDTOs;
using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.Wrappers.Imagen;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Imagen
{
    internal interface ICargarImagen
    {
        Task<CargarImagenWRP> CargarImagen(CargarImagenDTO request);
    }
}
