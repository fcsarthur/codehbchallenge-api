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

        public async Task<IEnumerable<string>> GetAllOrdered() =>
            await _dbConn.QueryAsync<string>(
                sql: "select * from Location order by nome desc",
                param: new { });

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
