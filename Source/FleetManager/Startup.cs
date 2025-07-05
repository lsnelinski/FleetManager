using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace FleetManager;

public class Startup
{
  private readonly WebApplicationBuilder _webApplicationBuilder = WebApplication.CreateBuilder();

  public WebApplication Build()
  {
    _webApplicationBuilder.Services.AddControllers();
    _webApplicationBuilder.Services.AddEndpointsApiExplorer();
    _webApplicationBuilder.Services.AddSwaggerGen(options =>
    {
      options.SwaggerDoc("v1",
        new OpenApiInfo
        {
          Version = "v1",
          Title = "FleetManager",
          Description = "A modern, cross-platform web-based fleet management system.",
          Contact = new OpenApiContact { Email = "lsnelinski@icloud.com", Name = "L. Snelinski" }
        });

      var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
      options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    });

    return _webApplicationBuilder.Build();
  }
}
