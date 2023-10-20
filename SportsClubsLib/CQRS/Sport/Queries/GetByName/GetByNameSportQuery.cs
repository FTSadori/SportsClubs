using SportsClubsLib.CQRS.Core.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Sport.Queries.GetByName
{
    public sealed class GetByNameSportQuery : IQuery
    {
        public string Name { get; }

        public GetByNameSportQuery(string name)
        {
            Name = name;
        }
    }
}
