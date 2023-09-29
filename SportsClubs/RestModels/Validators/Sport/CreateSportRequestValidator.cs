using FluentValidation;
using SportsClubs.RestModels.Sports;

namespace SportsClubs.RestModels.Validators.Sport
{
    public sealed class CreateSportRequestValidator : AbstractValidator<CreateSportsRequest>
    {
        public CreateSportRequestValidator() 
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name is required");
        }
    }
}
