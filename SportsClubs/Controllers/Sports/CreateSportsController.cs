using FluentValidation;
using FluentValidation.Results;
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
        private readonly IValidator<CreateSportsRequest> _validator;

        public CreateSportsController(
            ICreateSportCommandHandler createSports,
            IValidator<CreateSportsRequest> validator)
        {
            _createSports = createSports;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateSportsRequest request)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors
                    .Select(e => new { e.PropertyName, e.ErrorMessage }));
            }

            CreateSportCommand c = new(request.Name);
            await _createSports.Handle(c);

            return Ok();
        }
    }
}
