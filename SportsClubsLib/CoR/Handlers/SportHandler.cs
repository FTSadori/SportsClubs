using SportsClubsLib.CoR.Core;
using SportsClubsLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CoR.Handlers
{
    public sealed class SportHandler : AbstractHandler
    {
        private readonly SportsClubsDbContext _context;

        public SportHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public override async void Handle()
        {
            var sports = _context.Sports.ToList();
            foreach (var sport in sports)
                _context.Sports.Remove(sport);

            await _context.SaveChangesAsync();
            
            base.Handle();
        }
    }
}
