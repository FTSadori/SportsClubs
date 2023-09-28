using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Club;
using SportsClubsLib.CQRS.Club.Commands.Create;

namespace SportsClubs.Controllers.Sports
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "clubs")]
    public sealed class CreateClubController : ControllerBase
    {
        private readonly ICreateClubCommandHandler _command;

        public CreateClubController(ICreateClubCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateClubRequest request)
        {
            CreateClubCommand c = new(request.Name, request.Country, request.City, request.SportId);
            
            await _command.Handle(c);

            return Ok();
        }
    }
}
