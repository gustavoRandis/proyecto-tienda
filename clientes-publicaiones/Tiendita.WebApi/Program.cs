using Tiendita.WebApi;



//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//// Registrar los servicios de la aplicación
////builder.Services.AddTienditaServices(
////    builder.Configuration, "Connection2");

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();


//var builder = WebApplication.CreateBuilder(args)
//    .CreateWebApplication()
//    .ConfigureWebApplication();
//builder.Run();

var builder = WebApplication.CreateBuilder(args)
    .CreateWebApplication()
    .ConfigureWebApplication();
builder.Run();