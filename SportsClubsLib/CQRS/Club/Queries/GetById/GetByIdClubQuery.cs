using SportsClubsLib.CQRS.Core.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Club.Queries.GetById
{
    public sealed record GetByIdClubQuery : IQuery
    {
        public int Id { get; }

        public GetByIdClubQuery(int id)
        {
            Id = id;
        }
    }
}
