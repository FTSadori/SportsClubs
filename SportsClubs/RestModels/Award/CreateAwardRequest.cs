namespace SportsClubs.RestModels.Award
{
    public sealed record CreateAwardRequest
    {
        public string Name { get; }
        public int Year { get; }
        public int ClubId { get; }

        public CreateAwardRequest(string name, int year, int clubId)
        {
            Name = name;
            Year = year;
            ClubId = clubId;
        }
    }
}
