using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication().AddInfrastructure();

var app = builder.Build();
app.Run();