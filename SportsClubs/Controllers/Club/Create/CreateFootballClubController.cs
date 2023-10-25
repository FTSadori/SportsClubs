using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Club;
using SportsClubsLib.Builder.Builders.Club;
using SportsClubsLib.CQRS.Club.Commands.Create;
using SportsClubsLib.CQRS.Sport.Queries.GetByName;

namespace SportsClubs.Controllers.Club.Create
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "clubsBuilders")]
    public sealed class CreateFootballClubController : ControllerBase
    {
        private readonly ICreateClubCommandHandler _command;
        private readonly IValidator<CreateClubRequest> _validator;
        private readonly IGetByNameSportQueryHandler _query;

        public CreateFootballClubController(
            ICreateClubCommandHandler command,
            IGetByNameSportQueryHandler query,
            IValidator<CreateClubRequest> validator)
        {
            _query = query;
            _command = command;
            _validator = validator;
        }

        [HttpPost("createFootball")]
        public async Task<IActionResult> Create([FromBody] CreateBySportClubRequest request)
        {
            CreateClubBySportHelper helper = new CreateClubBySportHelper(_command, _query, _validator);

            return (await helper.Execute(request, new FootballClubBuilder())) ? Ok() : BadRequest();
        }
    }
}
