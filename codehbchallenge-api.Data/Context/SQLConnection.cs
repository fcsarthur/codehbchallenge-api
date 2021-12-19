using codehbchallenge_api.Data.Context.Interfaces;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using System.Data.SqlClient;

public sealed class SQLConnection : ISQLConnection
{
    public IConfiguration _configuration { get; }

    public SQLConnection(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IDbConnection Connection()
        => new NpgsqlConnection(this._configuration.GetConnectionString("PostgreSQL"));
}