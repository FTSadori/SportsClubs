using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Creators.ReportWriter.TxtReportWriter
{
    public abstract class TxtReportWriter : ReportWriter
    {
        protected override string FileType { get; } = "txt";
    }
}
