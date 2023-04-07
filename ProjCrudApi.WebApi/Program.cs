using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjCrudApi.Dominio.Interfaces.IClasses;
using ProjCrudApi.Dominio.Interfaces.IGenerica;
using ProjCrudApi.Dominio.Interfaces.IServicos;
using ProjCrudApi.Dominio.Servicos;
using ProjCrudApi.Infraestrutura.Configuracao;
using ProjCrudApi.Infraestrutura.Repositorios.Generico;
using ProjCrudApi.Infraestrutura.Repositorios.Repositorios;
using ProjCrudApi.WebApi.DTO.Configuracao;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextoBase>(options =>
        options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

// INTERFACE E REPOSITORIO
builder.Services.AddScoped(typeof(IGenerica<>), typeof(RepositorioGenerico<>));
builder.Services.AddScoped<IProduto, RepositorioProduto>();
builder.Services.AddScoped<ICategoria, RepositorioCategoria>();

// SERVIÇO DOMINIO
builder.Services.AddScoped<IServicoProduto, ServicoProduto>();
builder.Services.AddScoped<IServicoCategoria, ServicoCategoria>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

//builder.Services.AddSingleton<ContextBase>();
//builder.Services.AddScoped<ContextoBase>();

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
