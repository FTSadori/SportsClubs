using Microsoft.AspNetCore.Mvc;
using SportsClubsLib.Commands.Award.Create.Validator;
using SportsClubsLib.Commands.Award.Create;
using SportsClubs.RestModels.Award;

namespace SportsClubs.Controllers.Award
{
    [ApiController]
    [Route("awards")]
    [ApiExplorerSettings(GroupName = "awards")]
    public class CreateAwardController : ControllerBase
    {
        private readonly ICreateAwardCommand _command;
        private readonly ICreateAwardValidator _validator;

        public CreateAwardController(ICreateAwardCommand command, ICreateAwardValidator validator)
        {
            _command = command;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateAwardRequest request)
        {
            CreateAwardDto dto = new CreateAwardDto(request.Name, request.Year, request.ClubId);
            if (!await _validator.Execute(dto))
                return BadRequest();

            await _command.Execute(dto);
            return Ok();
        }
    }
}
