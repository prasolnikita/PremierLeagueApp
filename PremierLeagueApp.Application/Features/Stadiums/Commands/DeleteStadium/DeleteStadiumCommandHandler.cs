using LiteBus.Commands.Abstractions;
using PremierLeagueApp.Domain.Features.Stadiums;

namespace PremierLeagueApp.Application.Features.Stadiums.Commands.DeleteStadium
{
    public class DeleteStadiumCommandHandler : ICommandHandler<DeleteStadiumCommand>
    {
        private readonly IStadiumRepository _stadiumRepository;

        public DeleteStadiumCommandHandler (IStadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }

        public async Task HandleAsync(DeleteStadiumCommand command, CancellationToken cancellationToken = default)
        {
            var stadiumId = new StadiumId(command.StadiumId);

            var stadium = await _stadiumRepository.GetByIdAsync(stadiumId)
                ?? throw new KeyNotFoundException($"Stadium was not found");

            stadium.MarkAsDeleted();

            await _stadiumRepository.CommitAsync();
        }
    }
}
