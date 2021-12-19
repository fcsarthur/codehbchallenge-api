using System;

namespace codehbchallenge_api.Domain.Core.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {

    }
}
