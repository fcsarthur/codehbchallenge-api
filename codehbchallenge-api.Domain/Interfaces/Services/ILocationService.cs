using System.Collections.Generic;
using System.Threading.Tasks;

namespace codehbchallenge_api.Domain.Interfaces.Services
{
    public interface ILocationService
    {
        Task<IEnumerable<string>> GetAllOrdered();
    }
}
