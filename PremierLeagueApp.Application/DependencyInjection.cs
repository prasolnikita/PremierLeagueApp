using LiteBus.Commands;
using LiteBus.Extensions.Microsoft.DependencyInjection;
using LiteBus.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace PremierLeagueApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;

            services.AddLiteBus(configuration =>
            {
                configuration.AddCommandModule(module =>
                {
                    module.RegisterFromAssembly(currentAssembly);
                });

                configuration.AddQueryModule(module =>
                {
                    module.RegisterFromAssembly(currentAssembly);
                });
            });

            return services;
        }
    }
}
