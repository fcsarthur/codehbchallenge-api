using codehbchallenge_api.Data.Context.Interfaces;
using codehbchallenge_api.Domain.Entities;
using codehbchallenge_api.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using codehbchallenge_api.Domain.Queries.Responses;

namespace codehbchallenge_api.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly IDbConnection _dbConn;
        private bool _disposed = false;

        public LocationRepository(ISQLConnection sqlConnection)
        {
            _dbConn = sqlConnection.Connection();
        }

        public async Task<IEnumerable<Location>> GetAllOrdered() =>
            await _dbConn.QueryAsync<Location>(
                sql: "select * from Location order by nome desc",
                param: new { });

        public async Task<IEnumerable<GetNearestLocationsResponse>> GetAllOrderedByDistance(decimal lat, decimal lng)
        {
            //miles: 3959
            //kilometers: 6371

            return await _dbConn.QueryAsync<GetNearestLocationsResponse>(
                sql: "select *, ( 6371 * acos( cos( radians(-30.044100000000000) ) * cos( radians( latitude ) ) * cos( radians( longitude ) - radians(-51.219400000000000) ) + sin( radians(-30.044100000000000) ) * sin( radians( latitude ) ) ) ) distance from Location order by distance asc",
                param: new { });
        }


        #region IDisposableSupport
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_dbConn != null)
                    {
                        _dbConn.Close();
                        _dbConn.Dispose();
                    }
                }

                _disposed = true;
            }
        }
        #endregion
    }
}
