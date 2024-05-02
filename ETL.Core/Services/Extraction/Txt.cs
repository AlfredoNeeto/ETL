namespace ETL.Core.Services.Extraction
{
    public class Txt 
    {
        public void readFile(string filePath)
        {
            StreamReader read = new StreamReader(filePath);

            while (!read.EndOfStream)
            {
                var lines = read.ReadLine();

                foreach (var line in lines)
                {
                    Console.WriteLine(line + " ");
                }
                Console.WriteLine();
            }

            read.Close();
        }
    }
}
