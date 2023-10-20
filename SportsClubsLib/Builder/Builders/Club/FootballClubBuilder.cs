using SportsClubsLib.Builder.Builders.Club.Base;

namespace SportsClubsLib.Builder.Builders.Club
{
    public sealed class FootballClubBuilder : ClubBuilderBySport
    {
        public override void SetName(string clubName)
        {
            ClubProduct.Name = $"ФК \"{clubName}\"";
        }

        public override void SetSport()
        {
            ClubProduct.Sport = "Футбол";
        }
    }
}
