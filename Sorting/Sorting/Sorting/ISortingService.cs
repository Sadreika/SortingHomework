namespace Sorting.Controllers
{
    using System.Collections.Generic;

    public interface ISortingService
    {
        public IEnumerable<int> SortListOfNumbers(List<int> numberList);
    }
}
