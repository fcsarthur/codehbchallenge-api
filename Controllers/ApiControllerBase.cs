using codehbchallenge_api.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace codehbchallenge_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ApiControllerBase<T> : ControllerBase
    {
        private readonly ILogger<T> logger;

        public ApiControllerBase(ILogger<T> _logger)
        {
            logger = _logger;
        }

        protected virtual async Task<IActionResult> ApiResultAsync<T>(Func<Task<T>> fn)
        {
            try
            {
                var response = fn().GetAwaiter().GetResult();
                return new ApiResponseResult<T>(response);
            }
            catch (Exception ex)
            {
                //TODO - improve error logging
                this.logger.LogError(ex, "Error");

                var errors = new List<string>{ ex.Message };
                return new ApiResponseResult<IList<string>>(errors, HttpStatusCode.BadRequest);
            }
        }
    }
}