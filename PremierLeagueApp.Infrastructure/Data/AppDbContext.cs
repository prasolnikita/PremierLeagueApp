using Microsoft.EntityFrameworkCore;
using PremierLeagueApp.Domain.Features.Stadiums;

namespace PremierLeagueApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Stadium> Stadiums => Set<Stadium>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
