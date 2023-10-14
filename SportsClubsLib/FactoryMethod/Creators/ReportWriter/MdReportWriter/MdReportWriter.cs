using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Creators.ReportWriter.MdReportWriter
{
    public abstract class MdReportWriter : ReportWriter
    {
        protected override string FileType { get; } = "md";
    }
}
