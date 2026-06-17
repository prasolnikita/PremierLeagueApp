using Dapper;
using LiteBus.Queries.Abstractions;
using PremierLeagueApp.Application.Common;
using PremierLeagueApp.Application.Features.Stadiums.Queries.GetAllStadiums;

namespace PremierLeagueApp.Application.Features.Stadiums.Queries
{
    public class GetAllStadiumsQueryHandler : IQueryHandler<GetAllStadiumsQuery, IEnumerable<GetAllStadiumsDto>>
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        public GetAllStadiumsQueryHandler(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<GetAllStadiumsDto>> HandleAsync(GetAllStadiumsQuery query, CancellationToken cancellationToken = default)
        {
            using var connection = _connectionFactory.GetOpenConnection();
            const string sql = "SELECT Id, Name, City, Capacity, BuiltYear, PitchLength, PitchWidth FROM Stadiums WHERE IsDeleted = 0";
            return await connection.QueryAsync<GetAllStadiumsDto>(sql);
        }
    }
}
