using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Commands.Award.Create
{
    public sealed class CreateAwardCommand : ICreateAwardCommand
    {
        private readonly SportsClubsDbContext _context;

        public CreateAwardCommand(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Execute(CreateAwardDto data)
        {
            AwardEntity entity = new AwardEntity(data.Name, data.Year, data.ClubId);

            _context.Awards.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
