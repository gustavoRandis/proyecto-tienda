using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;

namespace Laputaquetepario.WebApi.EndPoint.Cliente
{
    public static class ClienteEndPointt
    {
        public static WebApplication TraerCliente(this WebApplication app)
        {
            app.MapGet("/cliente/{id}", async (ITraerClienteIdController controller, int id) =>
            {
                var actor = await controller.TraerCliente(id);

                if (actor == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (actor.NumeroError != 0 && !string.IsNullOrEmpty(actor.MensajeError))
                {
                    return Results.BadRequest(actor);

                }
                {
                    return Results.Ok(actor);
                }
            });

            return app;
        }
    }
}
