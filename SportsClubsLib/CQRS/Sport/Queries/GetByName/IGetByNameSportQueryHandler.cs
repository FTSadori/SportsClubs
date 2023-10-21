using SportsClubsLib.CQRS.Core.Query;
using SportsClubsLib.CQRS.Sport.Queries.GetById;
using SportsClubsLib.Dtos.Sport;

namespace SportsClubsLib.CQRS.Sport.Queries.GetByName
{
    public interface IGetByNameSportQueryHandler : IQueryHandler<GetByNameSportQuery, int?>
    {
    }
}
