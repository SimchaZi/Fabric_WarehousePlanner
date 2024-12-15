using Fabric_WarehousePlanner.Interfaces;

namespace Fabric_WarehousePlanner.Warehouse
{
    public class WarehouseAllocator : IWarehouseAllocator
    {
        public List<Product> Products { get; set; }
        Cell[,] WareHouseCells { get; set; }
        public WarehouseAllocator()
        {
            var productList = new ProductList();
            Products = productList.Products;
            WareHouseCells = new Cell[10, 10];
        }

        public (int row, int column) AllocateCell(string prodId, int quantity)
        {
            var productDetails = Products.FirstOrDefault(p => p.ProductId == prodId);

            var warehouseCells = WareHouseCells;

            if (productDetails == null) 
            {
                Console.WriteLine("Invalid product id");
                return (-1, -1);
            }

            for (int row = 0; row < warehouseCells.GetLength(0); row++)
            {
                for (int column = 0; column < warehouseCells.GetLength(1); column++)
                {
                    var cellContents = warehouseCells[row, column];

                    Cell contents;
                    if (cellContents == null)
                    {
                        if (quantity > 0 && quantity <= 10)
                        {
                            contents = new Cell()
                            {
                                ProductId = prodId,
                                HasCoolingSystem = productDetails.IsChilled,
                                HazardousMaterials = productDetails.IsHazardous,
                                FreeCapacity = quantity,
                            };
                            warehouseCells[row, column] = contents;
                            return (row, column);
                        }  
                    }
                    else if(cellContents.ProductId == prodId)
                    {
                        if (quantity > 0 && cellContents.FreeCapacity >= quantity)
                        {
                            cellContents.FreeCapacity -= quantity;
                            
                            warehouseCells[row, column] = cellContents;
                        }

                        return (row, column);
                    }
                }
            }

            return (-1,-1);
        }
    }
}
