namespace Fabric_WarehousePlanner.Interfaces
{
    public interface IProduct
    {
        string ProductId { get; set; }
        bool IsHazardous { get; set; }
        bool IsChilled { get; set; }
    }
}
