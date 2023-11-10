using SportsClubsLib.CQRS.Core.Query;
using SportsClubsLib.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Member.Queries.LoadToMediator
{
    public interface ILoadToMediatorQueryHandler : IQueryHandler<LoadToMediatorQuery, IEmailSenderMediator?>
    {

    }
}
