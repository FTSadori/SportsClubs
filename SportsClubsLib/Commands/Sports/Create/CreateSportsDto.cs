namespace SportsClubsLib.Commands.Sports.Create
{
    public sealed record CreateSportsDto
    {
        public string Name { get; }

        public CreateSportsDto(string name)
        {
            Name = name;
        }
    }
}
