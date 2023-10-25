using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Mediator
{
    public sealed class EmailSenderMediator : IEmailSenderMediator
    {
        private readonly SmtpClient _smtpClient;

        public EmailSenderMediator(SmtpClient client) 
        {
            _smtpClient = client;
        }

        private Dictionary<int, List<Participant>> _participants = new();
        
        public void AddParticipant(Participant participant)
        {
            if (_participants.ContainsKey(participant.ClubId)) 
            {
                _participants[participant.ClubId].Add(participant);
            }
            else
            {
                _participants.TryAdd(participant.ClubId, new List<Participant>() { participant });
            }
        }

        public void Send(string from, string subject, string body, int clubId)
        {
            if (!_participants.ContainsKey(clubId)) return;

            foreach (Participant participant in _participants[clubId])
            {
                participant.SendMessage(_smtpClient, from, subject, body);
            }
        }
    }
}
