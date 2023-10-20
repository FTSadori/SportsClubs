using SportsClubsLib.Builder.Builders.Club.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Builder.Builders.Club
{
    public sealed class VolleyballClubBuilder : ClubBuilderBySport
    {
        public override void SetName(string clubName)
        {
            ClubProduct.Name = $"ВК \"{clubName}\"";
        }

        public override void SetSport()
        {
            ClubProduct.Sport = "Волейбол";
        }
    }
}
