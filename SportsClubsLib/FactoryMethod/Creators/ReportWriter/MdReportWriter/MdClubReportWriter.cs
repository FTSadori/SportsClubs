using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos;
using SportsClubsLib.Dtos.Club;
using SportsClubsLib.FactoryMethod.Products.FileSector.MdFileSector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Creators.ReportWriter.MdReportWriter
{
    public sealed class MdClubReportWriter : MdReportWriter
    {
        public override void RenderFile(IData entity)
        {
            ClubDto club = entity as ClubDto ?? throw new ArgumentException("Given IEntity is not a ClubEntity");
            Sectors.Add(new MdHeaderSector($"Спортивний клуб {club.Name}"));
            Sectors.Add(new MdClubInfoSector(club));
            Sectors.Add(new MdMembersTableSector(club));
            Sectors.Add(new MdAwardTableSector(club));
            Sectors.Add(new MdLinksSector(new List<string> { 
                "https://uk.wikipedia.org/wiki/%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D1%96%D1%8F:%D0%A1%D0%BF%D0%BE%D1%80%D1%82%D0%B8%D0%B2%D0%BD%D1%96_%D0%BA%D0%BB%D1%83%D0%B1%D0%B8_%D0%A3%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D0%B8",
                "https://uk.wikipedia.org/wiki/%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D1%96%D1%8F:%D0%A1%D0%BF%D0%BE%D1%80%D1%82%D0%B8%D0%B2%D0%BD%D1%96_%D0%BA%D0%BB%D1%83%D0%B1%D0%B8_%D0%B7%D0%B0_%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D0%BE%D1%8E",
                "https://uk.wikipedia.org/wiki/%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D1%96%D1%8F:%D0%A1%D0%BF%D0%BE%D1%80%D1%82%D0%B8%D0%B2%D0%BD%D1%96_%D0%BA%D0%BB%D1%83%D0%B1%D0%B8_%D0%A3%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D0%B8_%D0%B7%D0%B0_%D1%80%D0%B5%D0%B3%D1%96%D0%BE%D0%BD%D0%BE%D0%BC"
            }));
        }
    }
}
