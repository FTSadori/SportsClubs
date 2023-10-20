using SportsClubsLib.Builder.Core;

namespace SportsClubsLib.Builder.Builders.Club.Base
{
    public interface IClubBuilderBySport : IBuilder
    {
        public void SetName(string clubName);
        public void SetCountry(string country);
        public void SetCity(string city);
        public void SetSport();
    }
}
