using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Presenters.ProductosPresentador;
using Tiendita.ReglasdeNegocio.Wrappers.Producto;

namespace Presentador.PresentadorProducto
{
    public class ObtenerTodosProductosPresentador : IObtenerTodosProductosPresentador
    {
        public WrapperObtenerTodosProductos Productos { get; private set; }

        public ValueTask Handle(WrapperObtenerTodosProductos productos)
        {
            //foreach (var actor in actors)
            //{
            //    Actors.Append(new WrapperSelectActor
            //    {
            //        IdActor = actor.IdActor,
            //        NombreActor = actor.NombreActor,
            //        ErrorNumber = actor.ErrorNumber,
            //        Message = string.IsNullOrEmpty(actor.Message) ? "" : actor.Message

            //    });
            //}
            Productos = productos;
            return ValueTask.CompletedTask;
        }
    }
}
