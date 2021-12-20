using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace codehbchallenge_api.Configurations
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "codehbchallenge-api",
                    Description = "CodeHB technical challenge API written in ASP.NET Core 3.1",
                    Contact = new OpenApiContact
                    {
                        Name = "Arthur Cardoso",
                        Url = new System.Uri("https://github.com/fcsarthur")
                    }
                });
            });

            return services;
        }
    }
}
