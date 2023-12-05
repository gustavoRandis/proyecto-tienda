using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;

namespace Tiendita.WebApi.EndPoint
{
    public static class TienditaObtenerTodosProductosEndPoint
    {
        public static WebApplication ObtenerTodosProductosEndPoint(this WebApplication app)
        {
            app.MapGet("/obtener todos los productos", async (IObtenerTodosProductosControlador controller) =>
            {
                var products = await controller.ObtenerTodos();

                if (products == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (products.NumeroError != 0 && !string.IsNullOrEmpty(products.Mensaje))
                {
                    return Results.BadRequest(products);
                }
                {
                    return Results.Ok(products);
                }
            });

            return app;
        }
    }
}
