using SportsClubsLib.Dtos.Club;
using SportsClubsLib.Dtos;
using SportsClubsLib.FactoryMethod.Products.FileSector.TxtFileSector;

namespace SportsClubsLib.FactoryMethod.Creators.ReportWriter.TxtReportWriter
{
    public sealed class TxtClubReportWriter : TxtReportWriter
    {
        public override void RenderFile(IData entity)
        {
            ClubDto? club = entity as ClubDto;
            if (club == null) return;

            Sectors.Add(new TxtHeaderSector($"Спортивний клуб {club.Name}"));
            Sectors.Add(new TxtClubInfoSector(club));
            Sectors.Add(new TxtMembersTableSector(club));
            Sectors.Add(new TxtAwardTableSector(club));
        }
    }
}
