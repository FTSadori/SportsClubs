using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Sports;
using SportsClubsLib.Commands.Sports.Create;
using SportsClubsLib.Commands.Sports.GetById;
using SportsClubsLib.Commands.Sports.GetById.Validator;
using SportsClubsLib.Data.Entities;

namespace SportsClubs.Controllers.Sports
{
    [ApiController]
    [Route("sports")]
    [ApiExplorerSettings(GroupName = "sports")]
    public class GetByIdSportsController : ControllerBase
    {
        private readonly IGetByIdSportsCommand _getbyidSports;
        private readonly IGetByIdSportsValidator _getbyidValid;

        public GetByIdSportsController(IGetByIdSportsCommand getbyidSports, IGetByIdSportsValidator getbyidValid)
        {
            _getbyidSports = getbyidSports;
            _getbyidValid = getbyidValid;
        }

        [HttpGet("{id:int}")]
        public async Task<SportEntity?> GetById(int id)
        {
            if (!await _getbyidValid.Execute(id))
                return null;

            return await _getbyidSports.Execute(id);
        }
    }
}
