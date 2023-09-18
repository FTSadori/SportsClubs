using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Commands.Sports.GetById.Validator
{
    public sealed class GetByIdSportsValidator : IGetByIdSportsValidator
    {
        private readonly SportsClubsDbContext _context;

        public GetByIdSportsValidator(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Execute(int id)
        {
            SportEntity? entity = await _context.Sports.Where(e => e.SportId == id).FirstOrDefaultAsync();
            return entity != null;
        }
    }
}
