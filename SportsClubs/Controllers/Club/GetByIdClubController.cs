using Microsoft.AspNetCore.Mvc;
using SportsClubsLib.CQRS.Club.Queries.GetById;
using SportsClubsLib.Dtos.Club;
using SportsClubsLib.FactoryMethod.Creators.ReportWriter.MdReportWriter;

namespace SportsClubs.Controllers.Club
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "clubs")]
    public class GetByIdClubController : ControllerBase
    {
        private readonly IGetByIdClubQueryHandler _getbyidClub;

        public GetByIdClubController(IGetByIdClubQueryHandler getbyidClub)
        {
            _getbyidClub = getbyidClub;
        }

        [HttpGet("{id:int}")]
        public async Task<ClubDto?> GetById(int id)
        {
            return await _getbyidClub.Handle(new GetByIdClubQuery(id));
        }
    }
}
