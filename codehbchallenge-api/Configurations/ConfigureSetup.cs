using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codehbchallenge_api.Configurations
{
    public static class ConfigureSetup
    {
        public static void UseConfigureSetup(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build());

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "codehbchallenge-api"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
