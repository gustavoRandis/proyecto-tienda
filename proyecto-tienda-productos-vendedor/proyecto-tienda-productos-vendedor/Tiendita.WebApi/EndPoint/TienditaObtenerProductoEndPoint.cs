using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;

namespace Tiendita.WebApi.EndPoint
{
    public static class TienditaObtenerProductoEndPoint
    {
        public static WebApplication ObtenerProductoEndPoint(this WebApplication app)
        {
            app.MapGet("obtener producto por ID", async (IObtenerProductoControlador controller, int id) =>
            {
                var product = await controller.ObtenerProducto(id);

                if (product == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (product.NumeroError != 0 && !string.IsNullOrEmpty(product.Mensaje))
                {
                    return Results.BadRequest(product);

                }
                {
                    return Results.Ok(product);
                }
            });

            return app;
        }
    }
}
