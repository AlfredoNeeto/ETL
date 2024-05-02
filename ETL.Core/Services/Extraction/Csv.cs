using ETL.Core.Entities;
using File = ETL.Core.Entities.File;

namespace ETL.Core.Services.Extraction
{
    public class Csv
    {
        public void readFile(string filePath)
        {
            StreamReader read = new StreamReader(filePath);

            while (!read.EndOfStream)
            {
                var line = read.ReadLine();

                var values = line.Split(";");

                foreach (var value in values)
                {
                    Console.WriteLine(value + " ");
                }
                Console.WriteLine();
            }

            read.Close();
        }
    }
}
