using SportsClubsLib.Dtos.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.TxtFileSector
{
    public sealed class TxtClubInfoSector : ITxtFileSector
    {
        private readonly ClubDto Club;

        public TxtClubInfoSector(ClubDto club)
        {
            Club = club;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"ОПИС КЛУБУ\n\n";
            result += $"Назва спортивного клубу: {Club.Name}\n";
            result += $"Країна: _{Club.Country}\n";
            result += $"Місто: {Club.City}\n";
            result += $"Вид спорту: {Club.SportName}\n\n";

            return result;
        }
    }
}
