using SportsClubsLib.CQRS.Core.Command;

namespace SportsClubsLib.CQRS.Member.Commands.Create
{
    public sealed record CreateMemberCommand : ICommand
    {
        public string Name { get; }
        public string Surname { get; }
        public string Patronymic { get; }
        public string Position { get; }
        public int ClubId { get; }

        public CreateMemberCommand(string name, string surname, string patronymic, string position, int clubId)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            ClubId = clubId;
        }
    }
}
