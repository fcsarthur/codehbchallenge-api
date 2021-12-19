using System.Data;

namespace codehbchallenge_api.Data.Context.Interfaces
{
    public interface ISQLConnection
    {
        IDbConnection Connection();
    }
}
