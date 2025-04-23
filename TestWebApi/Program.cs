using Microsoft.EntityFrameworkCore;
using TestWebApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DbCustomerContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionDB"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Redirect("/api/Customer/listar", permanent: false);
        return;
    }
    await next();
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
