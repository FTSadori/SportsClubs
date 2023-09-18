using SportsClubsLib.Commands.Core;

namespace SportsClubsLib.Commands.Club.Create.Validator
{
    public interface ICreateClubValidator : IAsyncCommand<CreateClubDto, bool>
    {

    }
}
