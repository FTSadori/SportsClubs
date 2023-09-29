using FluentValidation;
using SportsClubs.RestModels.Award;
using SportsClubs.RestModels.Club;
using SportsClubs.RestModels.Member;
using SportsClubs.RestModels.Sports;
using SportsClubs.RestModels.Validators.Award;
using SportsClubs.RestModels.Validators.Club;
using SportsClubs.RestModels.Validators.Member;
using SportsClubs.RestModels.Validators.Sport;

namespace SportsClubs.RestModels.Validators
{
    public static class ValidatorsInstaller
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services
                .AddScoped<IValidator<CreateSportsRequest>, CreateSportRequestValidator>()
                .AddScoped<IValidator<CreateClubRequest>, CreateClubRequestValidator>()
                .AddScoped<IValidator<CreateMemberRequest>, CreateMemberRequestValidator>()
                .AddScoped<IValidator<CreateAwardRequest>, CreateAwardRequestValidator>();

            return services;
        }
    }
}
