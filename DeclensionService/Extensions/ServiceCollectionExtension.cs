using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace DeclensionService.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddSwaggerGenWithOptions(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Сервис склонения", Version = "v1" });
                var filePath = Path.Combine(AppContext.BaseDirectory, "DeclensionService.xml");
                options.IncludeXmlComments(filePath, true);                
            });
            return services;
        }
    }
}
