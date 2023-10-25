using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.CQRS.Member.Commands.Create;
using SportsClubsLib.CQRS.Member.Queries.LoadToMediator;

namespace SportsClubsLib.Extensions.CQRS
{
    public static class MemberInstaller
    {
        public static IServiceCollection AddMemberCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateMemberCommandHandler, CreateMemberCommandHandler>();

            return services;
        }

        public static IServiceCollection AddMemberQueries(this IServiceCollection services)
        {
            services
                .AddScoped<ILoadToMediatorQueryHandler, LoadToMediatorQueryHandler>();

            return services;
        }
    }
}
