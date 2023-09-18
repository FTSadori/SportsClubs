using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Commands.Club.Create
{
    public sealed class CreateClubCommand : ICreateClubCommand
    {
        private readonly SportsClubsDbContext _context;

        public CreateClubCommand(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Execute(CreateClubDto data)
        {
            ClubEntity entity = new(data.Name, data.Country, data.City, data.SportId);

            _context.Clubs.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
