using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Mediator
{
    public interface IEmailSenderMediator
    {
        void AddParticipant(Participant participant);

        public void Send(string from, string subject, string body, int clubId);
    }
}
