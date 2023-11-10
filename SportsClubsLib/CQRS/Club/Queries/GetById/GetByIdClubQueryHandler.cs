using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos.Award;
using SportsClubsLib.Dtos.Club;
using SportsClubsLib.Dtos.Member;

namespace SportsClubsLib.CQRS.Club.Queries.GetById
{
    public sealed class GetByIdClubQueryHandler : IGetByIdClubQueryHandler
    {
        private readonly SportsClubsDbContext _context;

        public GetByIdClubQueryHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<ClubDto?> Handle(GetByIdClubQuery query)
        {
            ClubEntity? e = await _context.Clubs.Where(c => c.ClubId == query.Id).FirstOrDefaultAsync();

            ClubDto? dto = null;
            if (e != null)
            {
                var sport = await _context.Sports.Where(s => s.SportId == e.SportId).FirstOrDefaultAsync();

                var members = await _context.Members.Where(m => m.ClubId == e.ClubId).ToListAsync();
                List<MemberDto> membersDtos = new();
                foreach (var member in members)
                {
                    membersDtos.Add(new MemberDto(member.Name, member.Surname, member.Patronymic, member.Position, e.Name, member.Email));
                }

                var awards = await _context.Awards.Where(a => a.ClubId == e.ClubId).ToListAsync();
                List<AwardDto> awardsDtos = new();
                foreach (var award in awards)
                {
                    awardsDtos.Add(new AwardDto(award.Name, award.Year, e.Name));
                }

                dto = new(e.Name, e.Country, e.City, (sport == null) ? "" : sport.Name, membersDtos, awardsDtos);
            }

            return dto;
        }
    }
}
