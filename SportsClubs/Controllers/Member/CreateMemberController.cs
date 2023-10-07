using FluentValidation;
using FluentValidation.Results;
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
        private readonly IValidator<CreateMemberRequest> _validator;
        
        public CreateMemberController(
            ICreateMemberCommandHandler command,
            IValidator<CreateMemberRequest> validator)
        {
            _command = command;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateMemberRequest request)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors
                    .Select(e => new { e.PropertyName, e.ErrorMessage }));
            }
            CreateMemberCommand dto = new(request.Name, request.Surname, request.Patronymic, request.Position, request.ClubId);
            
            await _command.Handle(dto);
            return Ok();
        }
    }
}
