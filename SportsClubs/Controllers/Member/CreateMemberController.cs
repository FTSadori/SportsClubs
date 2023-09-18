using Microsoft.AspNetCore.Mvc;
using SportsClubsLib.Commands.Member.Create.Validator;
using SportsClubsLib.Commands.Member.Create;
using SportsClubs.RestModels.Member;
using SportsClubsLib.Data.Entities;

namespace SportsClubs.Controllers.Member
{
    [ApiController]
    [Route("members")]
    [ApiExplorerSettings(GroupName = "members")]
    public class CreateMemberController : ControllerBase
    {
        private readonly ICreateMemberCommand _command;
        private readonly ICreateMemberValidator _validator;

        public CreateMemberController(ICreateMemberCommand command, ICreateMemberValidator validator)
        {
            _command = command;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateMemberRequest request)
        {
            CreateMemberDto dto = new CreateMemberDto(request.Name, request.Surname, request.Patronymic, request.Position, request.ClubId);
            if (!await _validator.Execute(dto))
                return BadRequest();

            await _command.Execute(dto);
            return Ok();
        }
    }
}
