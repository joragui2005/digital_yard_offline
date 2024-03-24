using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using TipMexico.DigitalYard.Application.Interface;
using TipMexico.DigitalYard.Application.Main;
using TipMexico.DigitalYard.Infrastructure.Data;
using TipMexico.DigitalYard.Infrastructure.Interface;
using TipMexico.DigitalYard.Infrastructure.Repository;
using TipMexico.DigitalYard.Transversal.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IConnectionFactory, ConnectionFactory>();

builder.Services.AddScoped<IInspectionProcessApplication, InspectionProcessApplication>();

builder.Services.AddScoped<IInspectionProcessRepository, InspectionProcessRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
