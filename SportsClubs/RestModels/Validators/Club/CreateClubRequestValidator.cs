using FluentValidation;
using SportsClubs.RestModels.Club;
using SportsClubsLib.Data;

namespace SportsClubs.RestModels.Validators.Club
{
    public sealed class CreateClubRequestValidator : AbstractValidator<CreateClubRequest>
    {
        private readonly SportsClubsDbContext _context;

        public CreateClubRequestValidator(SportsClubsDbContext context) 
        {
            _context = context;

            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(r => r.City)
                .NotNull()
                .NotEmpty()
                .WithMessage("City is required");

            RuleFor(r => r.Country)
                .NotNull()
                .NotEmpty()
                .WithMessage("Country is required");

            RuleFor(r => r.SportId)
                .NotNull()
                .Must(i => _context.Sports.Where(s => s.SportId == i).FirstOrDefault() != null)
                .WithMessage("Sport id is wrong");

        }
    }
}
