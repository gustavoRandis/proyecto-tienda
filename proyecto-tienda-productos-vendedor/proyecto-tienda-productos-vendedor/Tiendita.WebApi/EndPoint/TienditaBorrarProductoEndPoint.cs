using reglasdenegocio.Entidades;
using Tiendita.Controladores.ControladoresProductos;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;

namespace Tiendita.WebApi.EndPoint
{
    public static class TienditaBorrarProductoEndPoint
    {
        public static WebApplication DeleteProductoEndPoint(this WebApplication app)
        {
            app.MapPut("/producto/delete/{id}", async (IBorrarProducto controller, int id) =>
            {
                var producto = await controller.BorrarProducto(id);
                if (producto == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (producto.NumeroError != 0 && !string.IsNullOrEmpty(producto.Mensaje))
                {
                    return Results.BadRequest(producto);
                }

                return Results.Ok(producto);
            });
            return app;
        }
    }
}
