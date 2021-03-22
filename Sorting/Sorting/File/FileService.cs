namespace Sorting.Controllers
{
    using System.Collections.Generic;
    using System.IO;

    public class FileService : IFileService
    {
        private FileStream GetFileStream(string fileName)
        {
            return new FileStream(fileName, FileMode.OpenOrCreate);
        }

        public string ReadFromFile(string fileName)
        {
            var stream = GetFileStream(fileName);

            string fileContent = string.Empty;

            using (StreamReader reader = new StreamReader(stream))
            {
                fileContent = reader.ReadToEnd();
            }

            return fileContent;
        }

        public void WriteToFile(IEnumerable<int> numberList, string fileName)
        {
            var stream = GetFileStream(fileName);

            using (StreamWriter writer = new StreamWriter(stream))
            {
                foreach (int number in numberList)
                {
                    writer.WriteLine(number);
                }
            }
        }
    }
}
