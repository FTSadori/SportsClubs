namespace SportsClubsLib.Data.Entities
{
    public class SportEntity : IEntity
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
