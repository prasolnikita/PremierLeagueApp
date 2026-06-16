using LiteBus.Commands.Abstractions;
using PremierLeagueApp.Domain.Features.Stadiums;

namespace PremierLeagueApp.Application.Features.Stadiums.Commands.CreateStadium
{
    public class CreateStadiumCommandHandler : ICommandHandler<CreateStadiumCommand, Guid>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public CreateStadiumCommandHandler(IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }

        public async Task<Guid> HandleAsync(CreateStadiumCommand command, CancellationToken cancellationToken = default)
        {
            var stadium = Stadium.Create(
                command.Name,
                command.City,
                command.Capacity,
                command.BuitYear,
                command.PitchLength,
                command.PitchWidth
            );

            await _stadiumRepository.AddAsync(stadium);
            await _stadiumRepository.CommitAsync();

            return stadium.Id.Value;
        }
    }
}
