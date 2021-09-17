using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.OpenApi.Models;
using System.IO;
using Microsoft.AspNetCore.Builder;

namespace Teste.Swagger
{
    public static class SwaggerSetup
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            return services.AddSwaggerGen(opt => 
            {
                opt.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Teste .Net Core",
                    Version = "v1",
                    Description = "Documentação realizada para o teste de Dev. 2021",
                    Contact = new OpenApiContact
                    {
                        Name = "Andre Goltz",
                        Email = "andregoltz@outlook.com.br"
                    }
                });

                string xmlPath = Path.Combine("wwwroot", "api-doc.xml");
                opt.IncludeXmlComments(xmlPath);
            });
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder application)
        {
            return application.UseSwagger().UseSwaggerUI(c =>
            {
                c.RoutePrefix = "documentation";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1"); 
            });
        }
    }
}
