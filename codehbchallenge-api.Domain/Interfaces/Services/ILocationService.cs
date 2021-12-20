using codehbchallenge_api.Domain.Entities;
using codehbchallenge_api.Domain.Queries.Requests;
using codehbchallenge_api.Domain.Queries.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace codehbchallenge_api.Domain.Interfaces.Services
{
    public interface ILocationService
    {
        Task<IEnumerable<Location>> GetAllOrdered();
        Task<IEnumerable<GetNearestLocationsResponse>> GetAllOrderedByDistance(GetNearestLocationsRequest request);
    }
}
