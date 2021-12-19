using codehbchallenge_api.Domain.Core.Interfaces;
using codehbchallenge_api.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace codehbchallenge_api.Domain.Interfaces.Repositories
{
    public interface ILocationRepository : IRepository<Location>
    {
        Task<IEnumerable<string>> GetAllOrdered();
    }
}
