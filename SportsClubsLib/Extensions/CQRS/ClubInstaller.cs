using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.CQRS.Club.Commands.Clear;
using SportsClubsLib.CQRS.Club.Commands.Create;
using SportsClubsLib.CQRS.Club.Queries.GetById;

namespace SportsClubsLib.Extensions.CQRS
{
    public static class ClubInstaller
    {
        public static IServiceCollection AddClubCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateClubCommandHandler, CreateClubCommandHandler>()
                .AddScoped<IClearClubCommandHandler, ClearClubCommandHandler>();

            return services;
        }

        public static IServiceCollection AddClubQueries(this IServiceCollection services)
        {
            services
                .AddScoped<IGetByIdClubQueryHandler, GetByIdClubQueryHandler>();

            return services;
        }
    }
}
