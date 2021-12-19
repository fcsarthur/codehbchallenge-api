using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codehbchallenge_api.Controllers
{
    [Route("api/v1/location"), ApiController]
    public class LocationController : ApiControllerBase<LocationController>
    {
        public LocationController(ILogger<LocationController> _logger) : base (_logger) { }

        [HttpGet("{value:int}")]
        public async Task<IActionResult> GetTeste([FromRoute] int value) =>
            await ApiResultAsync<string>(async () =>
            {
                return value.ToString();
            });
    }
}
