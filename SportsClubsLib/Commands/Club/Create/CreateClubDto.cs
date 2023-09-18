namespace SportsClubsLib.Commands.Club.Create
{
    public sealed record CreateClubDto
    {
        public string Name { get; }
        public string Country { get; }
        public string City { get; }
        public int SportId { get; }

        public CreateClubDto(string name, string country, string city, int sportId)
        {
            Name = name;
            Country = country;
            City = city;
            SportId = sportId;
        }
    }
}
