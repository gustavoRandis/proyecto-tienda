using Tiendita.WebApi;

var builder = WebApplication.CreateBuilder(args)
    .CreateWebApplication()
    .ConfigureWebApplication();
builder.Run();