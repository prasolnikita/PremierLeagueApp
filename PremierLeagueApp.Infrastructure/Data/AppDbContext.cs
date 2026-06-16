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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Stadium>(builder =>
            {
                builder.ToTable("Stadiums");

                builder.HasKey(s => s.Id);

                builder.Property(s => s.Id)
                    .HasConversion(
                        id => id.Value,
                        value => new StadiumId(value));

                builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
                builder.Property(s => s.City).IsRequired().HasMaxLength(100);
            })
        }
    }
}
