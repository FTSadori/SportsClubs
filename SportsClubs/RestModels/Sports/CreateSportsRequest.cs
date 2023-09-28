namespace SportsClubs.RestModels.Sports
{
    public sealed record CreateSportsRequest
    {
        public string Name { get; }

        public CreateSportsRequest(string name)
        {
            Name = name;
        }
    }
}
