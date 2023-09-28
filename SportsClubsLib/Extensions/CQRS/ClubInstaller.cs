using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.CQRS.Club.Commands.Create;

namespace SportsClubsLib.Extensions.CQRS
{
    public static class ClubInstaller
    {
        public static IServiceCollection AddClubCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateClubCommandHandler, CreateClubCommandHandler>();

            return services;
        }
    }
}
