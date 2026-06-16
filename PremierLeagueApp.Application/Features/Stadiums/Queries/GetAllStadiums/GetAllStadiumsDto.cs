namespace PremierLeagueApp.Application.Features.Stadiums.Queries.GetAllStadiums
{
    public class GetAllStadiumsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public int BuiltYear { get; set; }
        public int PitchLength { get; set; }
        public int PitchWidth { get; set; }
    }
}
