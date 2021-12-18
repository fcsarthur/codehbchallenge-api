using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codehbchallenge_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ApiControllerBase<T> : ControllerBase
    {
        private readonly ILogger<T> _logger;

        public ApiControllerBase(ILogger<T> logger)
        {
            _logger = logger;
        }

        
    }
}