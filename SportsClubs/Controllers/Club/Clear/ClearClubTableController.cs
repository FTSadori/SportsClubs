using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Club;
using SportsClubsLib.Builder.Builders.Club;
using SportsClubsLib.CQRS.Club.Commands.Clear;
using SportsClubsLib.CQRS.Club.Commands.Create;
using SportsClubsLib.CQRS.Sport.Queries.GetByName;

namespace SportsClubs.Controllers.Club.Drop
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "tableClear")]
    public sealed class ClearClubTableController : ControllerBase
    {
        private readonly IClearClubCommandHandler _command;

        public ClearClubTableController(
            IClearClubCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("clearClubs")]
        public async Task<IActionResult> Clear()
        {
            await _command.Handle(new ClearClubCommand());
            return Ok();
        }
    }
}
