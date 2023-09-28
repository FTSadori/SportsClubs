using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.CQRS.Member.Commands.Create;

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
    }
}
