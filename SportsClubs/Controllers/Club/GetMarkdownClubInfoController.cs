using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Club;
using SportsClubsLib.CQRS.Club.Commands.Create;
using SportsClubsLib.CQRS.Club.Queries.GetById;
using SportsClubsLib.Dtos.Club;
using SportsClubsLib.FactoryMethod.Creators.ReportWriter.MdReportWriter;
using System.Text.Json;

namespace SportsClubs.Controllers.Club
{
    [ApiController]
    [Route("clubs")]
    [ApiExplorerSettings(GroupName = "clubs")]
    public class GetMarkdownClubInfoController : ControllerBase
    {
        private readonly IGetByIdClubQueryHandler _getbyidClub;

        public GetMarkdownClubInfoController(IGetByIdClubQueryHandler getbyidClub)
        {
            _getbyidClub = getbyidClub;
        }

        [HttpGet("createMarkdownFile{id:int}")]
        public async Task CreateMarkdownFile(int id)
        {
            ClubDto? club = await _getbyidClub.Handle(new GetByIdClubQuery(id));
            
            if (club == null) return;
            MdClubReportWriter reportWriter = new();
            reportWriter.RenderFile(club);
            reportWriter.SaveToFile();
        }
    }
}
