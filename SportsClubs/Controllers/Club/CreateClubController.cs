using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Club;
using SportsClubsLib.CQRS.Club.Commands.Create;

namespace SportsClubs.Controllers.Sports
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "clubs")]
    public sealed class CreateClubController : ControllerBase
    {
        private readonly ICreateClubCommandHandler _command;
        private readonly IValidator<CreateClubRequest> _validator;

        public CreateClubController(
            ICreateClubCommandHandler command,
            IValidator<CreateClubRequest> validator)
        {
            _command = command;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateClubRequest request)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors
                    .Select(e => new { e.PropertyName, e.ErrorMessage }));
            }

            CreateClubCommand c = new(request.Name, request.Country, request.City, request.SportId);
            
            await _command.Handle(c);

            return Ok();
        }
    }
}
