namespace SportsClubs.RestModels.Club
{
    public sealed record CreateClubRequest
    {
        public string Name { get; }
        public string Country { get; }
        public string City { get; }
        public int SportId { get; }

        public CreateClubRequest(string name, string country, string city, int sportId)
        {
            Name = name;
            Country = country;
            City = city;
            SportId = sportId;
        }
    }
}
