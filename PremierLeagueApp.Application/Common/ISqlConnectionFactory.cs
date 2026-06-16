using System.Data;

namespace PremierLeagueApp.Application.Common
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
