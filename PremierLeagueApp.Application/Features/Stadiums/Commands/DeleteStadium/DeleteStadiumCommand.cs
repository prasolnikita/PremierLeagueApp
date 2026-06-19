using LiteBus.Commands.Abstractions;

namespace PremierLeagueApp.Application.Features.Stadiums.Commands.DeleteStadium
{
    public record DeleteStadiumCommand(Guid StadiumId) : ICommand;
}
