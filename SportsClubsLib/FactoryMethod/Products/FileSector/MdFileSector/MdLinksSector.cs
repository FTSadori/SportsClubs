using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.FactoryMethod.Products.FileSector.MdFileSector
{
    public sealed class MdLinksSector : IMdFileSector
    {
        private readonly List<string> Links = new();
        public MdLinksSector(List<string> links) 
        {
            Links = links;
        }

        public string ConvertToString()
        {
            string result = "";

            result += $"## Посилання\n";
            foreach (var link in Links)
            {
                result += $"1. {link}\n";
            }

            return result;
        }
    }
}
