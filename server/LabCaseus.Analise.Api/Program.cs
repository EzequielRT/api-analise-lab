using LabCaseus.Analise.Api.Configurations;
using LabCaseus.Analise.Application;
using LabCaseus.Analise.Infra.Data;

var builder = WebApplication.CreateBuilder(args);

builder.AddIdentityConfiguration();
builder.AddSerilogConfiguration(builder.Configuration);

// Add services to the container.
builder.Services.AddApiConfig(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfig(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseApiConfiguration();
app.UseSwaggerConfig();
app.Run();