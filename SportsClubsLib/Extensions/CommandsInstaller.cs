using Microsoft.Extensions.DependencyInjection;
using SportsClubsLib.Commands.Award.Create;
using SportsClubsLib.Commands.Award.Create.Validator;
using SportsClubsLib.Commands.Club.Create;
using SportsClubsLib.Commands.Club.Create.Validator;
using SportsClubsLib.Commands.Member.Create;
using SportsClubsLib.Commands.Member.Create.Validator;
using SportsClubsLib.Commands.Sports.Create;
using SportsClubsLib.Commands.Sports.GetById;
using SportsClubsLib.Commands.Sports.GetById.Validator;

namespace SportsClubsLib.Extensions
{
    public static class CommandsInstaller
    {
        public static IServiceCollection AddSportsCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateSportsCommand, CreateSportsCommand>()
                .AddScoped<IGetByIdSportsValidator, GetByIdSportsValidator>()
                .AddScoped<IGetByIdSportsCommand, GetByIdSportsCommand>();
            
            return services;
        }

        public static IServiceCollection AddClubCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateClubCommand, CreateClubCommand>()
                .AddScoped<ICreateClubValidator, CreateClubValidator>();

            return services;
        }

        public static IServiceCollection AddMemberCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateMemberCommand, CreateMemberCommand>()
                .AddScoped<ICreateMemberValidator, CreateMemberValidator>();

            return services;
        }

        public static IServiceCollection AddAwardCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateAwardCommand, CreateAwardCommand>()
                .AddScoped<ICreateAwardValidator, CreateAwardValidator>();

            return services;
        }
    }
}
