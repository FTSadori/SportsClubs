using SportsClubsLib.Data.Entities;
using SportsClubsLib.Dtos;
using SportsClubsLib.FactoryMethod.Products.FileSector;

namespace SportsClubsLib.FactoryMethod.Creators.ReportWriter
{
    public abstract class ReportWriter
    {
        protected readonly List<IFileSector> Sectors = new();
        protected virtual string FileType { get; } = "";

        public void SaveToFile()
        {
            string fileName = $"{DateTime.Now.ToFileTimeUtc()}.{FileType}";
            Console.WriteLine(fileName);
            StreamWriter writer = new(fileName);
            foreach (var sector in Sectors) 
            {
                writer.WriteLine(sector.ConvertToString());
            }
            writer.Close();
        }

        public abstract void RenderFile(IData entity);
    }
}
