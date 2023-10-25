using SportsClubsLib.Dtos.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SportsClubsLib.Mediator
{
    public sealed class Participant
    {
        public int ClubId { get; }
        private string Email { get; }

        public Participant(int clubId, string email)
        {
            ClubId = clubId;
            Email = email;
        }

        public void SendMessage(SmtpClient client, string from, string subject, string message)
        {
            client.SendAsync(from, Email, subject, message, null);
        }
    }
}
