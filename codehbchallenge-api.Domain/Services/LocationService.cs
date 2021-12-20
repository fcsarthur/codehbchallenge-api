using codehbchallenge_api.Domain.Entities;
using codehbchallenge_api.Domain.Interfaces.Repositories;
using codehbchallenge_api.Domain.Interfaces.Services;
using codehbchallenge_api.Domain.Queries.Requests;
using codehbchallenge_api.Domain.Queries.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace codehbchallenge_api.Domain.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IEnumerable<Location>> GetAllOrdered()
        {
            return await _locationRepository.GetAllOrdered();
        }

        public async Task<IEnumerable<GetNearestLocationsResponse>> GetAllOrderedByDistance(GetNearestLocationsRequest request)
        {
            return await _locationRepository.GetAllOrderedByDistance(request.lat, request.lng);
        }
    }
}
