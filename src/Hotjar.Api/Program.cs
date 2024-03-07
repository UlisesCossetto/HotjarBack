using Hotjar.Infrastructure.Data;
using Hotjar.Infrastructure.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager Configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .Build();

var _policyName = "configuracionCors";


builder.Services.AddCors(x =>
{
    x.AddPolicy(_policyName, builder =>
    {
        builder.WithOrigins(Configuration["UrlCors"])
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .SetPreflightMaxAge(TimeSpan.FromDays(365));
    });
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//builder.Services.AddCustomControllers();
//builder.Services.AddOptions(Configuration);

builder.Services.AddDbContextsMariaDB(Configuration);

builder.Services.AddServices();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(Configuration);

var app = builder.Build();
void ApplyMigrations()
{
    using var scope = app.Services.CreateScope();
    var _db = scope.ServiceProvider.GetRequiredService<HotjarDbContext>();
    if (_db.Database.GetPendingMigrations().Any() && environment.EnvironmentName != "Produccion") _db.Database.Migrate();
}
// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(_policyName);

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/index.html", "Hotjar Api");
});

app.UseAuthentication();

app.UseAuthorization();

//app.MapControllers();
ApplyMigrations();

app.Run();