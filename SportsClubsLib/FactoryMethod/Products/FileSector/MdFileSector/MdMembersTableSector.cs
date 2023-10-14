using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos.Club;
using SportsClubsLib.Dtos.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.MdFileSector
{
    public sealed class MdMembersTableSector : IMdFileSector
    {
        private readonly ClubDto Club;

        public MdMembersTableSector(ClubDto club)
        {
            Club = club;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"## Учасники клубу\n";
            result += $"|№  |ПІБ                            |Роль              \n";
            result += $"|---|-------------------------------|-----------------|\n";

            for(int i = 0; i < Club.Members.Count; ++i)
            {
                MemberDto mem = Club.Members[i];
                result += $"|{i + 1}|{mem.Surname} {mem.Name} {mem.Patronymic}|{mem.Position}|\n";
            }

            return result;
        }
    }
}
