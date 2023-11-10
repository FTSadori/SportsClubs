using Microsoft.AspNetCore.Mvc;
using SportsClubsLib.CQRS.Member.Queries.LoadToMediator;
using SportsClubsLib.Mediator;
using System.Net.Mail;
using System.Net;

namespace SportsClubs.Controllers.Member.SendEmail
{
    [ApiController]
    [Route("members")]
    [ApiExplorerSettings(GroupName = "emailMediator")]
    public sealed class SendEmailToClubMembersController : ControllerBase
    {
        public SendEmailToClubMembersController()
        {
        
        }

        [HttpGet("sendMessageHost")]
        public async Task<IActionResult> SendMessage(string from, string subject, string body, int clubId)
        {
            LoadEmailSenderController.Mediator?.Send(from, subject, body, clubId);
            return Ok();
        }
    }
}
