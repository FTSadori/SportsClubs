using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Commands.Sports.Create
{
    public sealed class CreateSportsCommand : ICreateSportsCommand
    {
        private readonly SportsClubsDbContext _context;

        public CreateSportsCommand(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Execute(CreateSportsDto data)
        {
            SportEntity entity = new SportEntity(data.Name);

            _context.Sports.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
