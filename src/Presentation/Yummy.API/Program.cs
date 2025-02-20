using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Yummy.API.Extensions;
using Yummy.Application.Common.Extensions;
using Yummy.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<YummyContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")).UseSnakeCaseNamingConvention();
});

builder.Services.AddApplicationService();
builder.Services.AddDependencyInjection();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.Title = "Yummy API";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
