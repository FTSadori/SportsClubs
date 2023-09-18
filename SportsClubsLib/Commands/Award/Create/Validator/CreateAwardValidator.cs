using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Commands.Award.Create.Validator
{
    public sealed class CreateAwardValidator : ICreateAwardValidator
    {
        private readonly SportsClubsDbContext _context;

        public CreateAwardValidator(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Execute(CreateAwardDto data)
        {
            if (data.Year < 1800 || data.Year > DateTime.Today.Year) return false;

            ClubEntity? entity = await _context.Clubs.Where(c => c.ClubId == data.ClubId).FirstOrDefaultAsync();
            return entity != null;
        }
    }
}
