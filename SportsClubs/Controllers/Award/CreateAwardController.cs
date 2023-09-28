using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Award;
using SportsClubsLib.CQRS.Award.Commands.Create;

namespace SportsClubs.Controllers.Award
{
    [ApiController]
    [Route("awards")]
    [ApiExplorerSettings(GroupName = "awards")]
    public class CreateAwardController : ControllerBase
    {
        private readonly ICreateAwardCommandHandler _command;
        
        public CreateAwardController(ICreateAwardCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateAwardRequest request)
        {
            CreateAwardCommand c = new(request.Name, request.Year, request.ClubId);
            
            await _command.Handle(c);
            return Ok();
        }
    }
}
