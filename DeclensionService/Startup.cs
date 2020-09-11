using DeclensionService.Declension;
using DeclensionService.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DeclensionService
{
    public class Startup
    {        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IDeclensionFacade>(new DeclensionFacade());
            services.AddSwaggerGenWithOptions();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            app.UseSwagger().UseSwaggerUI(swaggerUIOptions => swaggerUIOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "Сервис склонения (версия 1)"));
        }
    }
}
