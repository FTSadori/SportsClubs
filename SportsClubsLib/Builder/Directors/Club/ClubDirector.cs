using SportsClubsLib.Builder.Builders.Club.Base;
using SportsClubsLib.Builder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Builder.Directors.Club
{
    public sealed class ClubDirector : IClubDirector
    {
        private IClubBuilderBySport Builder { get; set; }

        public ClubDirector(IClubBuilderBySport builder) 
        {
            Builder = builder;
        }
        
        public void ChangeBuilder(IClubBuilderBySport builder)
        {
            Builder = builder;
        }

        public IProduct Make(string name, string country, string city)
        {
            Builder.Reset();
            Builder.SetName(name);
            Builder.SetCountry(country);
            Builder.SetCity(city);
            Builder.SetSport();
            return Builder.GetProduct();
        }
    }
}
