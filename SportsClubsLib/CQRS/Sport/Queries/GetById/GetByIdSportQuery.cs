using SportsClubsLib.CQRS.Core.Query;

namespace SportsClubsLib.CQRS.Sport.Queries.GetById
{
    public sealed record GetByIdSportQuery : IQuery
    {
        public int Id { get; }

        public GetByIdSportQuery(int id)
        {
            Id = id;
        }
    }
}
