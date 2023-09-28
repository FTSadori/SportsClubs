using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.CQRS.Member.Commands.Create
{
    internal class CreateMemberCommandHandler : ICreateMemberCommandHandler
    {
        private readonly SportsClubsDbContext _context;

        public CreateMemberCommandHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateMemberCommand command)
        {
            MemberEntity entity = new(command.Name, command.Surname, command.Patronymic, command.Position, command.ClubId);

            _context.Members.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
