using SportsClubsLib.CQRS.Core.Query;
using SportsClubsLib.Dtos.Club;

namespace SportsClubsLib.CQRS.Club.Queries.GetById
{
    public interface IGetByIdClubQueryHandler : IQueryHandler<GetByIdClubQuery, ClubDto?>
    {

    }
}
