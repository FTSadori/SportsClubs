using SportsClubsLib.Commands.Core;

namespace SportsClubsLib.Commands.Award.Create.Validator
{
    public interface ICreateAwardValidator : IAsyncCommand<CreateAwardDto, bool>
    {

    }
}
