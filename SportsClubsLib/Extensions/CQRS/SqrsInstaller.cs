using Microsoft.Extensions.DependencyInjection;

namespace SportsClubsLib.Extensions.CQRS
{
    public static class SqrsInstaller
    {
        public static IServiceCollection AddSQRS(this IServiceCollection services)
        {
            services
                .AddSportCommands()
                .AddSportQueries()
                .AddClubCommands()
                .AddClubQueries()
                .AddMemberCommands()
                .AddMemberQueries()
                .AddAwardCommands();

            return services;
        }
    }
}
