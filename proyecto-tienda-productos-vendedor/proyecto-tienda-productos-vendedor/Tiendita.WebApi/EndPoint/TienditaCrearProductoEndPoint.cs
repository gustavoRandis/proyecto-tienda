using Tiendita.ReglasdeNegocio.DTOs.productosDTO;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.ControladoresProductos;

namespace Tiendita.WebApi.EndPoint
{
    public static class TienditaCrearProductoEndPoint
    {
        public static WebApplication CreateProductoEndPoint(this WebApplication app)
        {
            app.MapPost("crear nuevo producto", async (CrearProductoDTO request, ICrearProductoControlador controller) =>
            {
                var result = await controller.CrearProducto(request);

                if (!string.IsNullOrEmpty(result.Mensaje) || result.ValidacionErrores != null)
                {
                    return Results.BadRequest(result);
                }
                else
                {
                    return Results.Ok(result);
                }

            });

            return app;
        }
    }
}
