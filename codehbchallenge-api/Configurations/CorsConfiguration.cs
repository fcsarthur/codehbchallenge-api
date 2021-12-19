using Microsoft.Extensions.DependencyInjection;
using System;


namespace codehbchallenge_api.Configurations
{
    public static class CorsConfiguration
    {
        private const string CorsPolicyName = "AllowAll";

        public static IServiceCollection AddCorsConfiguration(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(CorsPolicyName,
                    corsPolicyBuilder =>
                    {
                        corsPolicyBuilder.AllowAnyOrigin();
                        corsPolicyBuilder.AllowAnyHeader();
                        corsPolicyBuilder.AllowAnyMethod();
                    });
            });

            return services;
        }
    }
}

