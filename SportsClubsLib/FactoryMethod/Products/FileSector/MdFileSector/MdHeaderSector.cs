using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.MdFileSector
{
    public sealed class MdHeaderSector : IMdFileSector
    {
        private readonly string Title;

        public MdHeaderSector(string title)
        {
            Title = title;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"# {Title}\n";
            result += $"> Created: *{DateTime.Now.ToShortDateString()}*\n";
            result += $"By: *[Romenskyi  Viacheslav](https://github.com/FTSadori)*\n";
            result += $"For: *[Dmytro Rastoropov](https://github.com/rastoropovD)*\n";
            result += $"In [this](https://github.com/FTSadori/SportsClubs) project\n";

            return result;
        }
    }
}
