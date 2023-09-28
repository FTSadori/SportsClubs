using SportsClubsLib.CQRS.Core.Command;

namespace SportsClubsLib.CQRS.Club.Commands.Create
{
    public sealed record CreateClubCommand : ICommand
    {
        public string Name { get; }
        public string Country { get; }
        public string City { get; }
        public int SportId { get; }

        public CreateClubCommand(string name, string country, string city, int sportId)
        {
            Name = name;
            Country = country;
            City = city;
            SportId = sportId;
        }
    }
}
