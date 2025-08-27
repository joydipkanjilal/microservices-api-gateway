using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddOcelot();
//builder.Services.AddControllers();

// Add Ocelot json file configuration
builder.Configuration.AddJsonFile("ocelot.json");

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

//app.MapControllers();
app.MapGet("/", () => "Hello, World!");

app.UseRouting();
app.UseOcelot();

app.Run();