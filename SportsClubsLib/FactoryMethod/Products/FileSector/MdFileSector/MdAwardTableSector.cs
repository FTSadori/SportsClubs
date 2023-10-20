using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos.Award;
using SportsClubsLib.Dtos.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.MdFileSector
{
    public sealed class MdAwardTableSector : IMdFileSector
    {
        private readonly ClubDto Club;

        public MdAwardTableSector(ClubDto club)
        {
            Club = club;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"## Отримані нагороди\n";
            result += $"|№  |Назва                          |Рік              \n";
            result += $"|---|-------------------------------|-----------------|\n";

            for (int i = 0; i < Club.Awards.Count; ++i)
            {
                AwardDto aw = Club.Awards[i];
                result += $"|{i + 1}|{aw.Name}|{aw.Year}|\n";
            }

            return result;
        }
    }
}
