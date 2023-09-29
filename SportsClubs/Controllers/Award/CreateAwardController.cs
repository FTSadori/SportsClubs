using FluentValidation;
using FluentValidation.Results;
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
        private readonly IValidator<CreateAwardRequest> _validator;

        public CreateAwardController(
            ICreateAwardCommandHandler command,
            IValidator<CreateAwardRequest> validator
            )
        {
            _command = command;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateAwardRequest request)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors
                    .Select(e => new { e.PropertyName, e.ErrorMessage }));
            }

            CreateAwardCommand c = new(request.Name, request.Year, request.ClubId);
            
            await _command.Handle(c);
            return Ok();
        }
    }
}
