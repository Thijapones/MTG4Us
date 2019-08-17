using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

namespace Application.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class SwaggerExtensions
    {
        public static void SwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "MTG4Us",
                        Version = "v1",
                        Description = "Final Countdown Project",
                        Contact = new Contact
                        {
                            Name = "Only R - Only Research",
                            Url = "https://github.com/onlyresearch"
                        }
                    });

                var AppPath =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var XmlDocPath =
                    Path.Combine(AppPath, $"MTG4Us.Application.xml");

                c.IncludeXmlComments(XmlDocPath);
            });
        }

        public static void SwaggerApplication(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "MTG4Us");

                c.RoutePrefix = "docs";
            });
        }
    }
}