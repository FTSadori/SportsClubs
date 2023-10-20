using Microsoft.AspNetCore.Mvc;
using SportsClubsLib.CQRS.Club.Queries.GetById;
using SportsClubsLib.Dtos.Club;
using SportsClubsLib.FactoryMethod.Creators.ReportWriter.TxtReportWriter;

namespace SportsClubs.Controllers.Club
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "clubs")]
    public class GetTxtClubInfoController : ControllerBase
    {
        private readonly IGetByIdClubQueryHandler _getbyidClub;

        public GetTxtClubInfoController(IGetByIdClubQueryHandler getbyidClub)
        {
            _getbyidClub = getbyidClub;
        }

        [HttpGet("createTxtFile{id:int}")]
        public async Task CreateMarkdownFile(int id)
        {
            ClubDto? club = await _getbyidClub.Handle(new GetByIdClubQuery(id));

            if (club == null) return;
            TxtClubReportWriter reportWriter = new();
            reportWriter.RenderFile(club);
            reportWriter.SaveToFile();
        }
    }
}
