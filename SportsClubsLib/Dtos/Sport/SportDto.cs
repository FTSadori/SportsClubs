namespace SportsClubsLib.Dtos.Sport
{
    public sealed record SportDto : IData
    {
        public string Name { get; }

        public SportDto(string name)
        {
            Name = name;
        }
    }
}
