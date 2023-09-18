using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Club;
using SportsClubsLib.Commands.Club.Create;
using SportsClubsLib.Commands.Club.Create.Validator;

namespace SportsClubs.Controllers.Sports
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "clubs")]
    public sealed class CreateClubController : ControllerBase
    {
        private readonly ICreateClubCommand _command;
        private readonly ICreateClubValidator _validator;

        public CreateClubController(ICreateClubCommand command, ICreateClubValidator validator)
        {
            _command = command;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateClubRequest request)
        {
            CreateClubDto dto = new CreateClubDto(request.Name, request.Country, request.City, request.SportId);
            if (!await _validator.Execute(dto))
                return BadRequest();

            await _command.Execute(dto);
            return Ok();
        }
    }
}
