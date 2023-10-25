using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;
using SportsClubsLib.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Member.Queries.LoadToMediator
{
    public sealed class LoadToMediatorQueryHandler : ILoadToMediatorQueryHandler
    {
        private readonly SportsClubsDbContext _context;

        public LoadToMediatorQueryHandler(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task<IEmailSenderMediator?> Handle(LoadToMediatorQuery query)
        {
            IEmailSenderMediator mediator = new EmailSenderMediator(query.Client);

            foreach (MemberEntity member in _context.Members)
            {
                mediator.AddParticipant(new Participant(member.ClubId, member.Email));
            }

            return mediator;
        }
    }
}
