
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.CQRS.Award.Commands.Create
{
    public sealed class CreateAwardCommandHandler : ICreateAwardCommandHandler
    {
        private readonly SportsClubsDbContext _context;

        public CreateAwardCommandHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateAwardCommand command)
        {
            AwardEntity entity = new(command.Name, command.Year, command.ClubId);

            _context.Awards.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
