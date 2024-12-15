using Fabric_WarehousePlanner.Interfaces;

namespace Fabric_WarehousePlanner.Warehouse
{
    public class Product : IProduct
    {
        public string ProductId { get; set; }
        public bool IsHazardous { get; set; }
        public bool IsChilled { get; set; }
    }
}
