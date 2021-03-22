using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace SortingTesting
{
    [TestClass]
    public class SortingServiceUnitTest
    {
        [TestMethod]
        public void IsSorted()
        {
            SortingService sortingService = new SortingService();

            List<int> numberList = new List<int> { 5, 1, 6 };

            var sortedList = sortingService.SortListOfNumbers(numberList).ToList();

            List<int> testSortedList = new List<int> { 1, 5, 6 };

            CollectionAssert.AreEqual(sortedList, testSortedList);
        }

        [TestMethod]
        public void IsSortedBigNumbers()
        {
            SortingService sortingService = new SortingService();

            IEnumerable<int> maxValue = Enumerable.Repeat(int.MaxValue, 5);

            List<int> numberList = new List<int> { int.MinValue, int.MaxValue, 6, 10000, 55000};
            numberList.AddRange(maxValue.ToList());

            var sortedList = sortingService.SortListOfNumbers(numberList).ToList();

            List<int> testSortedList = new List<int> { int.MinValue, 6, 10000, 55000,  int.MaxValue };
            testSortedList.AddRange(maxValue.ToList());

            CollectionAssert.AreEqual(sortedList, testSortedList);
        }
    }
}

