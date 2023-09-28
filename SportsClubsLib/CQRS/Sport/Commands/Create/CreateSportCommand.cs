using SportsClubsLib.CQRS.Core.Command;

namespace SportsClubsLib.CQRS.Sport.Commands.Create
{
    public sealed record CreateSportCommand : ICommand
    {
        public string Name { get; }

        public CreateSportCommand(string name)
        {
            Name = name;
        }
    }
}
