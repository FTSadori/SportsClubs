using FluentValidation;
using SportsClubs.RestModels.Award;
using SportsClubsLib.Data;

namespace SportsClubs.RestModels.Validators.Award
{
    public sealed class CreateAwardRequestValidator : AbstractValidator<CreateAwardRequest>
    {
        private readonly SportsClubsDbContext _context;

        public CreateAwardRequestValidator(SportsClubsDbContext context)
        {
            _context = context;

            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(r => r.ClubId)
                .NotNull()
                .Must(i => _context.Clubs.Where(c => c.ClubId == i).FirstOrDefault() != null)
                .WithMessage("Club id is wrong");

            RuleFor(r => r.Year)
                .NotNull()
                .Must(y => y > 1800 && y <= DateTime.Today.Year)
                .WithMessage("Year is wrong");
        }
    }
}
