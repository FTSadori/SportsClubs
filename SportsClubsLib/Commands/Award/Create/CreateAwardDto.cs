namespace SportsClubsLib.Commands.Award.Create
{
    public sealed record CreateAwardDto
    {
        public string Name { get; }
        public int Year { get; }
        public int ClubId { get; }
        
        public CreateAwardDto(string name, int year, int clubId)
        {
            Name = name;
            Year = year;
            ClubId = clubId;
        }
    }
}
