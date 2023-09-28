namespace SportsClubs.RestModels.Member
{
    public sealed record CreateMemberRequest
    {
        public string Name { get; }
        public string Surname { get; }
        public string Patronymic { get; }
        public string Position { get; }
        public int ClubId { get; }

        public CreateMemberRequest(string name, string surname, string patronymic, string position, int clubId)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            ClubId = clubId;
        }
    }
}
