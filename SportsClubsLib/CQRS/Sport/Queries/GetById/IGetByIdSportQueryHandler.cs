using SportsClubsLib.CQRS.Core.Query;
using SportsClubsLib.Dtos.Sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Sport.Queries.GetById
{
    public interface IGetByIdSportQueryHandler : IQueryHandler<GetByIdSportQuery, SportDto?>
    {

    }
}
