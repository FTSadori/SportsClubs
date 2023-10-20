using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SportsClubs.RestModels.Club;
using SportsClubsLib.Builder.Builders.Club;
using SportsClubsLib.Builder.Builders.Club.Base;
using SportsClubsLib.Builder.ConcreteProducts;
using SportsClubsLib.Builder.Directors.Club;
using SportsClubsLib.CQRS.Club.Commands.Create;
using SportsClubsLib.CQRS.Sport.Queries.GetByName;

namespace SportsClubs.Controllers.Club.Create
{
    public sealed class CreateClubBySportHelper
    {
        private readonly ICreateClubCommandHandler _command;
        private readonly IValidator<CreateClubRequest> _validator;
        private readonly IGetByNameSportQueryHandler _query;

        public CreateClubBySportHelper(
            ICreateClubCommandHandler command,
            IGetByNameSportQueryHandler query,
            IValidator<CreateClubRequest> validator)
        {
            _query = query;
            _command = command;
            _validator = validator;
        }

        public async Task<IActionResult> Execute(CreateBySportClubRequest request, IClubBuilderBySport builder)
        {
            IClubDirector director = new ClubDirector(builder);

            ClubProduct? clubProduct = director.Make(request.Name, request.Country, request.City) as ClubProduct;
            if (clubProduct == null) { return new BadRequestResult(); }

            int sportId = await _query.Handle(new GetByNameSportQuery(clubProduct.Sport)) ?? -1;
            if (sportId == -1) { return new NotFoundResult(); }

            CreateClubRequest fullRequest = new CreateClubRequest(clubProduct.Name, clubProduct.Country, clubProduct.City, sportId);

            ValidationResult validationResult = await _validator.ValidateAsync(fullRequest);

            if (!validationResult.IsValid)
            {
                return new BadRequestResult();
            }

            CreateClubCommand c = new(fullRequest.Name, fullRequest.Country, fullRequest.City, fullRequest.SportId);

            await _command.Handle(c);

            return new OkResult();
        }
    }
}
