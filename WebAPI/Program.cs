using WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices(builder.Configuration);

var app = builder.Build();

app.CreateDatabaseIfNotExists();

app.UseMiddleware();

app.Run();
