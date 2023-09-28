namespace SportsClubsLib.Dtos.Sport
{
    public sealed record SportDto
    {
        public string Name { get; }

        public SportDto(string name)
        {
            Name = name;
        }
    }
}
