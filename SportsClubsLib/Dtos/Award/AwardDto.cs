namespace SportsClubsLib.Dtos.Award
{
    public sealed record AwardDto
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string ClubName { get; set; }

        public AwardDto(string name, int year, string clubName)
        {
            Name = name;
            Year = year;
            ClubName = clubName;
        }
    }
}
