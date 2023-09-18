namespace SportsClubsLib.Data.Entities
{
    public class ClubEntity
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public int SportId { get; set; }
        public virtual SportEntity SportEntity { get; set; }

        public virtual List<MemberEntity> Members { get; set; }
        public virtual List<AwardEntity> Awards { get; set; }

        public ClubEntity(string name, string country, string city, int sportId)
        {
            Name = name;
            Country = country;
            City = city;
            SportId = sportId;
        }
    }
}
