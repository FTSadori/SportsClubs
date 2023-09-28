using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.CQRS.Club.Commands.Create
{
    public sealed class CreateClubCommandHandler : ICreateClubCommandHandler
    {
        private readonly SportsClubsDbContext _context;

        public CreateClubCommandHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateClubCommand command)
        {
            ClubEntity entity = new(command.Name, command.Country, command.City, command.SportId);

            _context.Clubs.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
