using SportsClubsLib.Dtos.Club;
using SportsClubsLib.Dtos.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.TxtFileSector
{
    public sealed class TxtMembersTableSector : ITxtFileSector
    {
        private readonly ClubDto Club;

        public TxtMembersTableSector(ClubDto club)
        {
            Club = club;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"УЧАСНИКИ КЛУБУ\n\n";
            
            for (int i = 0; i < Club.Members.Count; ++i)
            {
                MemberDto mem = Club.Members[i];
                result += $"{i + 1}. {mem.Surname} {mem.Name} {mem.Patronymic} ({mem.Position})\n";
            }
            result += '\n';

            return result;
        }
    }
}
