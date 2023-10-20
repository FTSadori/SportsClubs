using SportsClubsLib.Builder.Core;

namespace SportsClubsLib.Builder.ConcreteProducts
{
    public class ClubProduct : IProduct
    {
        public string Name { get; set; }
        public string Sport { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
