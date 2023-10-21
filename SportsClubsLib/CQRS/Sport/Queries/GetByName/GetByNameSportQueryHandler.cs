using SportsClubsLib.CQRS.Sport.Queries.GetById;
using SportsClubsLib.Data.Entities;
using SportsClubsLib.Data;
using SportsClubsLib.Dtos.Sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportsClubsLib.CQRS.Sport.Queries.GetByName
{
    public sealed class GetByNameSportQueryHandler : IGetByNameSportQueryHandler
    {
        private readonly SportsClubsDbContext _context;

        public GetByNameSportQueryHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<int?> Handle(GetByNameSportQuery query)
        {
            SportEntity? entity = await _context.Sports.Where(s => s.Name == query.Name).FirstOrDefaultAsync();

            int? id = null;
            if (entity != null) { id = entity.SportId; }

            return id;
        }
    }
}
