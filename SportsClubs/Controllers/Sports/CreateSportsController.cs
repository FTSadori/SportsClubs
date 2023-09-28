using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Sports;
using SportsClubsLib.CQRS.Sport.Commands.Create;

namespace SportsClubs.Controllers.Sports
{
    [ApiController]
    [Route("sports")]
    [ApiExplorerSettings(GroupName = "sports")]
    public sealed class CreateSportsController : ControllerBase
    {
        private readonly ICreateSportCommandHandler _createSports;

        public CreateSportsController(ICreateSportCommandHandler createSports)
        {
            _createSports = createSports;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateSportsRequest request)
        {
            CreateSportCommand c = new(request.Name);
            await _createSports.Handle(c);

            return Ok();
        }
    }
}
