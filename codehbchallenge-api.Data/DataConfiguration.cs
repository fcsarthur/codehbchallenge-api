using codehbchallenge_api.Data.Context.Interfaces;
using codehbchallenge_api.Data.Repositories;
using codehbchallenge_api.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace codehbchallenge_api.Data
{
    public static class DataConfiguration
    {
        public static void AddDataConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ISQLConnection, SQLConnection>();

            services.AddScoped<ILocationRepository, LocationRepository>();
        }
    }
}
