namespace Sorting.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        private readonly ISortingService sortingService;
        private readonly IFileService fileService;

        public NumbersController(ISortingService sortingService, IFileService fileService)
        {
            this.sortingService = sortingService;
            this.fileService = fileService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(fileService.ReadFromFile("sortedNumbers.txt"));
        }

        [HttpPost]
        [Route("sort")]
        public ActionResult Post([FromBody] List<int> numberList)
        {
            var sortedNumbers = sortingService.SortListOfNumbers(numberList);
            fileService.WriteToFile(sortedNumbers, "sortedNumbers.txt");
            return Created($"numbers",sortedNumbers);
        }
    }
}
