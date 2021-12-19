using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace codehbchallenge_api.Common
{
    public class ApiResponseResult<T> : IActionResult
    {
        public class CustomHttpResponse
        {
            public T Data { get; set; }
            public HttpStatusCode StatusCode { get; set; }
            public IList<string> Notifications { get; set; }
            public string Exception { get; set; }
        }

        CustomHttpResponse customHttpResponse = new CustomHttpResponse();

        public ApiResponseResult(T value, HttpStatusCode statusCode = HttpStatusCode.OK, IList<string> notifications = null, object exception = null)
        {
            customHttpResponse.Data = value;
            customHttpResponse.StatusCode = statusCode;
            customHttpResponse.Notifications = notifications;
            customHttpResponse.Exception = exception?.GetType()?.Name;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(customHttpResponse) { };

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
