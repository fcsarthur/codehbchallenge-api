using System.ComponentModel.DataAnnotations;

namespace codehbchallenge_api.Domain.Queries.Requests
{
    public class GetNearestLocationsRequest
    {
        [Required]
        public decimal lat { get; set; }
        
        [Required]
        public decimal lng { get; set; }
    }
}
