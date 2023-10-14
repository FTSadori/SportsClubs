using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.MdFileSector
{
    public sealed class MdClubInfoSector : IMdFileSector
    {
        private readonly ClubDto Club;

        public MdClubInfoSector(ClubDto club) 
        {
            Club = club;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"## Опис клубу\n";
            result += $"Назва спортивного клубу: _{Club.Name}_\n";
            result += $"Країна: _{Club.Country}_\n";
            result += $"Місто: _{Club.City}_\n";
            result += $"Вид спорту: _{Club.SportName}_\n";

            return result;
        }
    }
}
