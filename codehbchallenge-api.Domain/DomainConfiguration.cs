using codehbchallenge_api.Domain.Interfaces.Services;
using codehbchallenge_api.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace codehbchallenge_api.Domain
{
    public static class DomainConfiguration
    {
        public static IServiceCollection AddDomainConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ILocationService, LocationService>();

            return services;
        }
    }
}
