using codehbchallenge_api.Domain.Entities;
using codehbchallenge_api.Domain.Interfaces.Repositories;
using codehbchallenge_api.Domain.Interfaces.Services;
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

        public Task<IEnumerable<Location>> GetAllOrdered()
        {
            return _locationRepository.GetAllOrdered();
        }
    }
}
