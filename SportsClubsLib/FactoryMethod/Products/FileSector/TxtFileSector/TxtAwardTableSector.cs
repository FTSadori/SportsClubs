using SportsClubsLib.Dtos.Award;
using SportsClubsLib.Dtos.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.TxtFileSector
{
    public sealed class TxtAwardTableSector : ITxtFileSector
    {
        private readonly ClubDto Club;

        public TxtAwardTableSector(ClubDto club)
        {
            Club = club;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"ОТРИМАНІ НАГОРОДИ\n\n";
            
            for (int i = 0; i < Club.Awards.Count; ++i)
            {
                AwardDto aw = Club.Awards[i];
                result += $"{i + 1}. {aw.Name} ({aw.Year})\n";
            }
            result += '\n';

            return result;
        }
    }
}
