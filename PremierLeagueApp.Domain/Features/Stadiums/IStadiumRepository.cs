namespace PremierLeagueApp.Domain.Features.Stadiums
{
    public interface IStadiumRepository
    {
        Task AddAsync(Stadium stadium);
        Task<Stadium?> GetByIdAsync(StadiumId id);
        Task CommitAsync();
    }
}
