using SportsClubsLib.CoR.Core;
using SportsClubsLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace SportsClubsLib.CoR.Handlers
{
    public sealed class AwardHandler : AbstractHandler
    {
        private readonly SportsClubsDbContext _context;

        public AwardHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public override async void Handle()
        {
            var awards = _context.Awards.ToList();
            foreach (var award in awards)
                _context.Awards.Remove(award);
            
            await _context.SaveChangesAsync();
            
            base.Handle();
        }
    }
}
