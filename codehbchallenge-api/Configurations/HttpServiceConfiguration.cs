using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codehbchallenge_api.Configurations
{
    public static class HttpServiceConfiguration
    {
        public static IServiceCollection AddHttpServicesConfiguration(this IServiceCollection services)
        {
            //TODO - implement httpservice

            //services.AddHttpClient<HttpService>();

            return services;
        }
    }
}
