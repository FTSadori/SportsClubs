using SportsClubsLib.Builder.Builders.Club.Base;
using SportsClubsLib.Builder.Core;

namespace SportsClubsLib.Builder.Directors.Club
{
    public interface IClubDirector : IDirector
    {
        public void ChangeBuilder(IClubBuilderBySport builder);
        public IProduct Make(string name, string country, string city);
    }
}
