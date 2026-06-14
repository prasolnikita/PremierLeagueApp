namespace PremierLeagueApp.Domain.Features.Stadiums
{
    public record StadiumId(Guid Value)
    {
        public static StadiumId New() => new(Guid.NewGuid());
    }
}
