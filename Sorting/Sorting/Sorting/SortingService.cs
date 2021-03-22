namespace Sorting.Controllers
{
    using System.Collections.Generic;

    public class SortingService : ISortingService
    {
        private bool IsSorted(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                if (numberList[i] > numberList[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
        public IEnumerable<int> SortListOfNumbers(List<int> numberList)
        {
            var stopSorting = false;

            while (!stopSorting)
            {
                numberList = SwapAdjacentNumbers(numberList);

                if (IsSorted(numberList))
                {
                    stopSorting = !stopSorting;
                }
            }

            return numberList;
        }

        private List<int> SwapAdjacentNumbers(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                if (numberList[i] > numberList[i + 1])
                {
                    int tempNumber = numberList[i];
                    numberList[i] = numberList[i + 1];
                    numberList[i + 1] = tempNumber;
                }
            }

            return numberList;
        }
    }
}
