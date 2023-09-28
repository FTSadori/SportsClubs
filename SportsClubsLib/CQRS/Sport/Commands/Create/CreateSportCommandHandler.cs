using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Sport.Commands.Create
{
    public sealed class CreateSportCommandHandler : ICreateSportCommandHandler
    {
        private readonly SportsClubsDbContext _context;

        public CreateSportCommandHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateSportCommand command)
        {
            SportEntity sportEntity = new(command.Name);
            _context.Sports.Add(sportEntity);

            await _context.SaveChangesAsync();
        }
    }
}
