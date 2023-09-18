using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Commands.Club.Create.Validator
{
    public sealed class CreateClubValidator : ICreateClubValidator
    {
        private readonly SportsClubsDbContext _context;

        public CreateClubValidator(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Execute(CreateClubDto data)
        {
            SportEntity? entity = await _context.Sports.Where(s => s.SportId == data.SportId).FirstOrDefaultAsync();
            return entity != null;
        }
    }
}
