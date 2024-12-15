namespace Fabric_WarehousePlanner.Interfaces
{
    public interface IWarehouseAllocator
    {
        public (int row, int column) AllocateCell(string prodId, int quantity);
    }
}
