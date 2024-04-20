using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();
app.UseSwagger().UseSwaggerUI();
app.MapControllers();
app.Run();
