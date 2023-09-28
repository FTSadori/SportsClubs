using SportsClubsLib.CQRS.Core.Command;

namespace SportsClubsLib.CQRS.Award.Commands.Create
{
    public sealed record CreateAwardCommand : ICommand
    {
        public string Name { get; }
        public int Year { get; }
        public int ClubId { get; }

        public CreateAwardCommand(string name, int year, int clubId)
        {
            Name = name;
            Year = year;
            ClubId = clubId;
        }
    }
}
