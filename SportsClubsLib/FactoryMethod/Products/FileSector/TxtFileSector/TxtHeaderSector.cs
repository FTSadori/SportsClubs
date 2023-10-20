using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.TxtFileSector
{
    public sealed class TxtHeaderSector : ITxtFileSector
    {
        private readonly string Title;

        public TxtHeaderSector(string title)
        {
            Title = title;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"{Title.ToUpper()}\n\n\n";
            result += $"Created: {DateTime.Now.ToShortDateString()}\n";
            result += $"By: Romenskyi  Viacheslav\n";
            result += $"For: Dmytro Rastoropov\n";
            result += $"In https://github.com/FTSadori/SportsClubs project\n\n";

            return result;
        }
    }
}
