using FluentValidation;
using SportsClubs.RestModels.Member;
using SportsClubsLib.Data;

namespace SportsClubs.RestModels.Validators.Member
{
    public sealed class CreateMemberRequestValidator : AbstractValidator<CreateMemberRequest>
    {
        private readonly SportsClubsDbContext _context;

        public CreateMemberRequestValidator(SportsClubsDbContext context)
        {
            _context = context;

            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name is required");
            
            RuleFor(r => r.Surname)
                .NotNull()
                .NotEmpty()
                .WithMessage("Surname is required");

            RuleFor(r => r.Position)
                .NotNull()
                .NotEmpty()
                .WithMessage("Position is required");

            RuleFor(r => r.ClubId)
                .NotNull()
                .Must(i => _context.Clubs.Where(c => c.ClubId == i).FirstOrDefault() != null)
                .WithMessage("Club id is wrong");
        }
    }
}
