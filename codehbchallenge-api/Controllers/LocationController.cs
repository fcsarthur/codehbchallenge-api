using codehbchallenge_api.Domain.Entities;
using codehbchallenge_api.Domain.Interfaces.Services;
using codehbchallenge_api.Domain.Queries.Requests;
using codehbchallenge_api.Domain.Queries.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codehbchallenge_api.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/location"), ApiController]
    public class LocationController : ApiControllerBase<LocationController>
    {
        private readonly ILocationService _locationService;

        public LocationController(ILogger<LocationController> _logger, ILocationService locationService) : base (_logger) 
        {
            _locationService = locationService;
        }

        /// <summary>
        /// List all locations on DataPOA webservice
        /// </summary>
        /// <response code="200">Returns the generated collection</response>
        /// <response code="400">If there were any problems on the request</response>  
        [HttpGet("list-locations")]
        [ProducesResponseType(typeof(IEnumerable<Location>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLocations() =>
            await ApiResultAsync(async () =>
            {
                return await _locationService.GetAllOrdered();
            });

        /// <summary>
        /// List all locations on DataPOA webservice ordered by distance based on params
        /// </summary>
        /// <response code="200">Returns the generated collection containing the distance in Km</response>
        /// <response code="400">If there were any problems on the request</response>  
        [HttpGet("nearest-locations")]
        [ProducesResponseType(typeof(IEnumerable<GetNearestLocationsResponse>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetNearestLocations([FromQuery] GetNearestLocationsRequest request) =>
            await ApiResultAsync(async () =>
            {
                return await _locationService.GetAllOrderedByDistance(request);
            });
    }
}
