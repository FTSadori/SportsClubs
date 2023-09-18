namespace SportsClubsLib.Commands.Member.Create
{
    public sealed record CreateMemberDto
    {
        public string Name { get; }
        public string Surname { get; }
        public string Patronymic { get; }
        public string Position { get; }
        public int ClubId { get; }

        public CreateMemberDto(string name, string surname, string patronymic, string position, int clubId)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            ClubId = clubId;
        }
    }
}
