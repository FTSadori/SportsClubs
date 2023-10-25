using Microsoft.AspNetCore.Mvc;
using SportsClubsLib.CQRS.Club.Commands.Clear;
using SportsClubsLib.CQRS.Member.Queries.LoadToMediator;
using SportsClubsLib.Mediator;
using System.Net;
using System.Net.Mail;

namespace SportsClubs.Controllers.Member.SendEmail
{
    [ApiController]
    [Route("members")]
    [ApiExplorerSettings(GroupName = "emailMediator")]
    public sealed class LoadEmailSenderController : ControllerBase
    {
        public static IEmailSenderMediator? Mediator { get; private set; }

        private readonly ILoadToMediatorQueryHandler _command;

        public LoadEmailSenderController(
            ILoadToMediatorQueryHandler command)
        {
            _command = command;
        }

        [HttpGet("loadToMediator")]
        public async Task<IActionResult> Load(string host, int port, string email, string password, bool enableSsl)
        {
            SmtpClient smtpClient = new(host)
            {
                Port = port,
                Credentials = new NetworkCredential(email, password),
                EnableSsl = enableSsl,
            };

            Mediator = await _command.Handle(new LoadToMediatorQuery(smtpClient));
            return Ok();
        }
    }
}
