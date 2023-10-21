using SportsClubsLib.Builder.Builders.Club.Base;

namespace SportsClubsLib.Builder.Builders.Club
{
    public sealed class BasketballClubBuilder : ClubBuilderBySport
    {
        public override void SetName(string clubName)
        {
            ClubProduct.Name = $"БК \"{clubName}\"";
        }

        public override void SetSport()
        {
            ClubProduct.Sport = "Баскетбол";
        }
    }
}
