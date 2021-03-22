namespace Sorting.Controllers
{
    using System.Collections.Generic;

    public interface IFileService
    {
        public string ReadFromFile(string fileName);
        public void WriteToFile(IEnumerable<int> numbersList, string fileName);
    }
}
