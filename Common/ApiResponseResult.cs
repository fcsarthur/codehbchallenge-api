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

        public ApiResponseResult(T _value, HttpStatusCode _statusCode = HttpStatusCode.OK, IList<string> _notifications = null, object _exception = null)
        {
            customHttpResponse.Data = _value;
            customHttpResponse.StatusCode = _statusCode;
            customHttpResponse.Notifications = _notifications;
            customHttpResponse.Exception = _exception?.GetType()?.Name;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(customHttpResponse) { };

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
