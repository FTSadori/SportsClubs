using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Sports;
using SportsClubsLib.Commands.Sports.Create;

namespace SportsClubs.Controllers.Sports
{
    [ApiController]
    [Route("sports")]
    [ApiExplorerSettings(GroupName = "sports")]
    public sealed class CreateSportsController : ControllerBase
    {
        private readonly ICreateSportsCommand _createSports;

        public CreateSportsController(ICreateSportsCommand createSports)
        {
            _createSports = createSports;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateSportsRequest request)
        {
            CreateSportsDto dto = new CreateSportsDto(request.Name);
            await _createSports.Execute(dto);

            return Ok();
        }
    }
}
