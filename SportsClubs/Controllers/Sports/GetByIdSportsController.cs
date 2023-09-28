using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Sports;
using SportsClubsLib.CQRS.Sport.Queries.GetById;
using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos.Sport;

namespace SportsClubs.Controllers.Sports
{
    [ApiController]
    [Route("sports")]
    [ApiExplorerSettings(GroupName = "sports")]
    public class GetByIdSportsController : ControllerBase
    {
        private readonly IGetByIdSportQueryHandler _getbyidSport;

        public GetByIdSportsController(IGetByIdSportQueryHandler getbyidSport)
        {
            _getbyidSport = getbyidSport;
        }

        [HttpGet("{id:int}")]
        public async Task<SportDto?> GetById(int id)
        {
            return await _getbyidSport.Handle(new GetByIdSportQuery(id));
        }
    }
}
