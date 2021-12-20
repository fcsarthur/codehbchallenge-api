using codehbchallenge_api.Domain.Interfaces.Services;
using codehbchallenge_api.Domain.Queries.Requests;
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
        private readonly ILocationService _locationService;

        public LocationController(ILogger<LocationController> _logger, ILocationService locationService) : base (_logger) 
        {
            _locationService = locationService;
        }

        [HttpGet("list-locations")]
        public async Task<IActionResult> GetLocations() =>
            await ApiResultAsync(async () =>
            {
                return await _locationService.GetAllOrdered();
            });

        [HttpGet("nearest-locations")]
        public async Task<IActionResult> GetNearestLocations([FromQuery] GetNearestLocationsRequest request) =>
            await ApiResultAsync(async () =>
            {
                return await _locationService.GetAllOrderedByDistance(request);
            });
    }
}
