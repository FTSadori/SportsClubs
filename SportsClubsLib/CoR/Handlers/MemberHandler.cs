using SportsClubsLib.CoR.Core;
using SportsClubsLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CoR.Handlers
{
    public sealed class MemberHandler : AbstractHandler
    {
        private readonly SportsClubsDbContext _context;

        public MemberHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public override void Handle()
        {
            var members = _context.Members.ToList();
            foreach (var member in members)
                _context.Members.Remove(member);
            
            _context.SaveChanges();
            
            base.Handle();
        }
    }
}
