using SportsClubsLib.Commands.Core;

namespace SportsClubsLib.Commands.Member.Create.Validator
{
    public interface ICreateMemberValidator : IAsyncCommand<CreateMemberDto, bool>
    {

    }
}
