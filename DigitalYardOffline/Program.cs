using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Text.Json.Serialization;
using TipMexico.DigitalYard.Application.Interface;
using TipMexico.DigitalYard.Application.Main;
using TipMexico.DigitalYard.Infrastructure.Data;
using TipMexico.DigitalYard.Infrastructure.Interface;
using TipMexico.DigitalYard.Infrastructure.Repository;
using TipMexico.DigitalYard.Transversal.Common;
using TipMexico.DigitalYard.WebAPI.Configuration;
using TipMexico.DigitalYard.WebAPI.Extensions;

var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
IConfiguration _configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .AddJsonFile($"appsettings.{environmentName}.json")
               .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
               .Build();

var builder = WebApplication.CreateBuilder(args);

//elimina los espacios de los json de entrada
//elimina los json con redundancia
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    x.JsonSerializerOptions.Converters.Add(new ConfigureJsonStringConvert());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle ();
builder.Services.AddSwaggerDocumentation();
builder.Services.AddMvc();
builder.Services.AddModules(_configuration);


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterAutoFacModules(_configuration);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerDocumentation();
}

app.UseHttpsRedirection();

app.UseModules();

app.UseAuthorization();

app.MapControllers();


app.Run();
