using codehbchallenge_api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace codehbchallenge_api.Domain.Queries.Responses
{
    public class GetNearestLocationsResponse : Location
    {
        public decimal distance { get; set; }
    }
}
