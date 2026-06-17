using Microsoft.EntityFrameworkCore;
using PremierLeagueApp.Domain.Features.Stadiums;
using PremierLeagueApp.Infrastructure.Data;
namespace PremierLeagueApp.Infrastructure.Repositories
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly AppDbContext _context;

        public StadiumRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Stadium stadium)
        {
            await _context.Stadiums.AddAsync(stadium);
        }

        public async Task<Stadium?> GetByIdAsync(StadiumId id)
        {
            return await _context.Stadiums.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
