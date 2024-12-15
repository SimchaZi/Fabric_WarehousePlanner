using Fabric_WarehousePlanner.Interfaces;

namespace Fabric_WarehousePlanner.Warehouse
{
    public class Cell : ICell
    {
        public bool HasCoolingSystem { get; set; }
        public bool HazardousMaterials { get; set; }
        public string ProductId { get; set; }
        public int FreeCapacity { get; set; }

        public Cell()
        {
            FreeCapacity = 10;
        }
    }
}
