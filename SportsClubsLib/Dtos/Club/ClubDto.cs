using SportsClubsLib.Dtos.Sport;
using SportsClubsLib.Dtos.Award;
using SportsClubsLib.Dtos.Member;

namespace SportsClubsLib.Dtos.Club
{
    public sealed record ClubDto
    {
        public string Name { get; }
        public string Country { get; }
        public string City { get; }

        public string SportName { get; }

        public List<MemberDto> Members { get; }
        public List<AwardDto> Awards { get; }


        public ClubDto(string name, string country, string city,
            string sportName, List<MemberDto> members, List<AwardDto> awards)
        {
            Name = name;
            Country = country;
            City = city;
            SportName = sportName;
            Members = members;
            Awards = awards;
        }
    }
}
