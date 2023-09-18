using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Commands.Member.Create.Validator
{
    public sealed class CreateMemberValidator : ICreateMemberValidator
    {
        private readonly SportsClubsDbContext _context;

        public CreateMemberValidator(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Execute(CreateMemberDto data)
        {
            ClubEntity? entity = await _context.Clubs.Where(c => c.ClubId == data.ClubId).FirstOrDefaultAsync();
            return entity != null;
        }
    }
}
