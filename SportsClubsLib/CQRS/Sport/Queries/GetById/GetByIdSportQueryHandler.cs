using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos.Sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Sport.Queries.GetById
{
    public sealed class GetByIdSportQueryHandler : IGetByIdSportQueryHandler
    {
        private readonly SportsClubsDbContext _context;

        public GetByIdSportQueryHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<SportDto?> Handle(GetByIdSportQuery query)
        {
            SportEntity? entity = await _context.Sports.Where(s => s.SportId == query.Id).FirstOrDefaultAsync();

            SportDto? dto = null;
            if (entity != null) { dto = new(entity.Name); }

            return dto;
        }
    }
}
