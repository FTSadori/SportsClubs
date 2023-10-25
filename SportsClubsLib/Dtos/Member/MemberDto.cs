namespace SportsClubsLib.Dtos.Member
{
    public sealed record MemberDto : IData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public string ClubName { get; set; }
        public string Email { get; set; }

        public MemberDto(string name, string surname, string patronymic, string position, string clubName, string email)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            ClubName = clubName;
            Email = email;
        }
    }
}
