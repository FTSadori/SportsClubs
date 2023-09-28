namespace SportsClubsLib.Data.Entities
{
    public class AwardEntity
    {
        public int AwardId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public int ClubId { get; set; }
        public virtual ClubEntity ClubEntity { get; set; }

        public AwardEntity(string name, int year, int clubId)
        {
            Name = name;
            Year = year;
            ClubId = clubId;
        }
    }
}
