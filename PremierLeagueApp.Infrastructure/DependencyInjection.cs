using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PremierLeagueApp.Application.Common;
using PremierLeagueApp.Domain.Features.Stadiums;
using PremierLeagueApp.Infrastructure.Data;
using PremierLeagueApp.Infrastructure.Repositories;

namespace PremierLeagueApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefauldConnection")
                ?? throw new InvalidOperationException("Connection string not found.");

            services.AddTransient<ISqlConnectionFactory>(_ => new SqlConnectionFactory(connectionString));

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IStadiumRepository, StadiumRepository>();

            return services;
        }
    }
}
