using LiteBus.Commands.Abstractions;

namespace PremierLeagueApp.Application.Features.Stadiums.Commands.CreateStadium
{
    public class CreateStadiumCommand : ICommand<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public int BuitYear { get; set; }
        public int PitchLength { get; set; }
        public int PitchWidth { get; set; }
    }
}
