namespace Fabric_WarehousePlanner.Interfaces
{
    public interface ICell
    {
        bool HasCoolingSystem { get; set; }
        bool HazardousMaterials { get; set; }
        string ProductId { get; set; }
        int FreeCapacity { get; set; }
    }
}
