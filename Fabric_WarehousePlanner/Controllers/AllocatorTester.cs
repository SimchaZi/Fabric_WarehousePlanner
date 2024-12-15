using Fabric_WarehousePlanner.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fabric_WarehousePlanner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AllocatorTester : ControllerBase
    {
        private readonly IWarehouseAllocator _warehouseAllocator;

        private readonly ILogger<AllocatorTester> _logger;

        public AllocatorTester(ILogger<AllocatorTester> logger, IWarehouseAllocator warehouseAllocator)
        {
            _warehouseAllocator = warehouseAllocator;
            _logger = logger;
        }

        [HttpGet(Name = "RunTests")]
        public IActionResult Get()
        {
            var resultsList = new List<(int, int)>();


            resultsList.Add(_warehouseAllocator.AllocateCell("bread", 2));
            resultsList.Add(_warehouseAllocator.AllocateCell("bamba", 6));
            resultsList.Add(_warehouseAllocator.AllocateCell("milk", 6));
            resultsList.Add(_warehouseAllocator.AllocateCell("apple", 11));
            resultsList.Add(_warehouseAllocator.AllocateCell("stain remover", 7));
            resultsList.Add(_warehouseAllocator.AllocateCell("insulin", 10));

            Console.WriteLine("results: " + String.Join(",", resultsList));

            return Ok();
        }
    }
}
