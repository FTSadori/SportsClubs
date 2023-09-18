using SportsClubsLib.Commands.Core;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Commands.Sports.GetById
{
    public interface IGetByIdSportsCommand : IAsyncCommand<int, SportEntity>
    {

    }
}
