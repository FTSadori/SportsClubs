using SportsClubsLib.CoR.Handlers;
using SportsClubsLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Club.Commands.Clear
{
    internal class ClearClubCommandHandler : IClearClubCommandHandler
    {
        private readonly SportsClubsDbContext _context;

        public ClearClubCommandHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public Task Handle(ClearClubCommand command)
        {
            AwardHandler awardHandler = new(_context);
            MemberHandler memberHandler = new(_context);
            ClubHandler clubHandler = new(_context);
            
            awardHandler.SetNext(memberHandler);
            memberHandler.SetNext(clubHandler);

            awardHandler.Handle();

            return _context.SaveChangesAsync();
        }
    }
}
