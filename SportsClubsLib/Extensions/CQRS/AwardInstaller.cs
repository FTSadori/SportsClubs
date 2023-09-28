using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.CQRS.Award.Commands.Create;

namespace SportsClubsLib.Extensions.CQRS
{
    public static class AwardInstaller
    {
        public static IServiceCollection AddAwardCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateAwardCommandHandler, CreateAwardCommandHandler>();

            return services;
        }
    }
}
