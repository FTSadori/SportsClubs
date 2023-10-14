namespace SportsClubsLib.Data.Entities
{
    public class SportEntity
    {
        public int SportId { get; set; }
        public string Name { get; set; }
        public virtual List<ClubEntity> Clubs { get; set; }

        public SportEntity(string name)
        {
            Name = name;
        }
    }
}
