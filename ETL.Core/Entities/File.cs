using ETL.Core.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ETL.Core.Entities
{
    public class File : IFile
    {
        private string filePath = AppDomain.CurrentDomain.BaseDirectory + "Files\\";
        private string fileName { get; set; } = string.Empty;

        public string getFileName()
        {
            return fileName;
        }

        public string getFilePath()
        {
            return filePath;
        }

        public void setFileName(string fileName)
        {
            this.fileName = fileName;
        }
    }
}
