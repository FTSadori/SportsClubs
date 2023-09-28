using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.CQRS.Sport.Commands.Create;
using SportsClubsLib.CQRS.Sport.Queries.GetById;

namespace SportsClubsLib.Extensions.CQRS
{
    public static class SportInstaller
    {
        public static IServiceCollection AddSportCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateSportCommandHandler, CreateSportCommandHandler>();

            return services;
        }

        public static IServiceCollection AddSportQueries(this IServiceCollection services)
        {
            services
                .AddScoped<IGetByIdSportQueryHandler, GetByIdSportQueryHandler>();

            return services;
        }
    }
}
