using SportsClubsLib.CQRS.Core.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Member.Queries.LoadToMediator
{
    public sealed record LoadToMediatorQuery : IQuery
    {
        public SmtpClient Client { get; }

        public LoadToMediatorQuery(SmtpClient client) 
        {
            Client = client;
        }
    }
}
