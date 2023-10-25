using SportsClubsLib.CoR.Core;
using SportsClubsLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CoR.Handlers
{
    public sealed class ClubHandler : AbstractHandler
    {
        private readonly SportsClubsDbContext _context;

        public ClubHandler(SportsClubsDbContext context) 
        {
            _context = context;
        }

        public override async void Handle()
        {
            var clubs = _context.Clubs.ToList();
            foreach (var club in clubs)
                _context.Clubs.Remove(club);

            await _context.SaveChangesAsync();

            base.Handle();
        }
    }
}
