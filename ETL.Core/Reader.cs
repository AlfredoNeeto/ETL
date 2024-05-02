using ETL.Core.Interfaces;

namespace ETL.Core
{
    public class Reader : IReader
    {
        private readonly IFile file;

        public Reader(IFile file)
        {
            this.file = file;
        }

        public string readFile()
        {
            string filePath = file.getFilePath() + file.getFileName();

            string fileExtension = Path.GetExtension(filePath);

            return string.Empty;

            //Todo: Implementar a leiura do aruqivo de acordo com a extensão.
                
        }
    }
}
