using SportsClubsLib.Builder.ConcreteProducts;
using SportsClubsLib.Builder.Core;

namespace SportsClubsLib.Builder.Builders.Club.Base
{
    public abstract class ClubBuilderBySport : IClubBuilderBySport
    {
        protected ClubProduct ClubProduct { get; set; } = new ClubProduct();

        public IProduct GetProduct()
        {
            return ClubProduct;
        }

        public void Reset()
        {
            ClubProduct = new ClubProduct();
        }

        public void SetCity(string city)
        {
            ClubProduct.City = city;
        }

        public void SetCountry(string country)
        {
            ClubProduct.Country = country;
        }

        public abstract void SetName(string clubName);
        public abstract void SetSport();
    }
}
