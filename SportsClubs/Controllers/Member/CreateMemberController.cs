using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Member;
using SportsClubsLib.CQRS.Member.Commands.Create;

namespace SportsClubs.Controllers.Member
{
    [ApiController]
    [Route("members")]
    [ApiExplorerSettings(GroupName = "members")]
    public class CreateMemberController : ControllerBase
    {
        private readonly ICreateMemberCommandHandler _command;
        
        public CreateMemberController(ICreateMemberCommandHandler command)
        {
            _command = command;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateMemberRequest request)
        {
            CreateMemberCommand dto = new(request.Name, request.Surname, request.Patronymic, request.Position, request.ClubId);
            
            await _command.Handle(dto);
            return Ok();
        }
    }
}
