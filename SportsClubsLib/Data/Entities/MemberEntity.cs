namespace SportsClubsLib.Data.Entities
{
    public class MemberEntity
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public int ClubId { get; set; }
        public virtual ClubEntity ClubEntity { get; set; }

        public MemberEntity(string name, string surname, string patronymic, string position, int clubId, string email)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            ClubId = clubId;
            Email = email;
        }
    }
}
