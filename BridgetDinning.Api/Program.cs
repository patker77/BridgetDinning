using BridgetDinning.Application;
using BridgetDinning.Application.Services.Authentication;
using BridgetDinning.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services
    .AddApplication()
    .AddInfrastructure();



var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();

}
