using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Controllers;

namespace SortingTesting
{
    [TestClass]
    public class FileServiceUnitTest
    {
        [TestMethod]
        public void ReadFromFile_RightFileName_FileRead()
        {
            FileService fileService = new FileService();

            string textFromFile = fileService.ReadFromFile("sortedNumbers.txt");
            string testText = "2\r\n4\r\n5\r\n9\r\n11\r\n999\r\n1001\r\n5464567\r\n";

            Assert.AreEqual(textFromFile, testText);
        }

        [TestMethod]
        public void ReadFromFile_WrongFileName_FileNotRead()
        {
            FileService fileService = new FileService();

            string textFromFile = fileService.ReadFromFile("sortedNumbersWrong.txt");

            Assert.AreEqual(textFromFile, string.Empty);
        }
    }
}
