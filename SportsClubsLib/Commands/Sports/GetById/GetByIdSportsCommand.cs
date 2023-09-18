using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Commands.Sports.GetById
{
    public sealed class GetByIdSportsCommand : IGetByIdSportsCommand
    {
        private readonly SportsClubsDbContext _context;

        public GetByIdSportsCommand(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<SportEntity> Execute(int id)
        {
            return await _context.Sports.Where(s => s.SportId == id).FirstOrDefaultAsync() ?? new SportEntity("");
        }
    }
}
