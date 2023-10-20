namespace SportsClubs.RestModels.Club
{
    public sealed record CreateBySportClubRequest
    {
        public string Name { get; }
        public string Country { get; }
        public string City { get; }

        public CreateBySportClubRequest(string name, string country, string city)
        {
            Name = name;
            Country = country;
            City = city;
        }
    }
}
