namespace Fabric_WarehousePlanner.Warehouse
{
    public class ProductList
    {
        public List<Product> Products { get; set; }
        public ProductList()
        {
            Products = new List<Product>();
            InitProducts();
        }

        public void InitProducts()
        {
            Products.Add(new Product() { ProductId = "milk", IsChilled = true, IsHazardous = false });
            Products.Add(new Product() { ProductId = "yogurt", IsChilled = true, IsHazardous = false });
            Products.Add(new Product() { ProductId = "cheese", IsChilled = true, IsHazardous = false });
            Products.Add(new Product() { ProductId = "insulin", IsChilled = true, IsHazardous = true });

            Products.Add(new Product() { ProductId = "bleach", IsChilled = false, IsHazardous = true});
            Products.Add(new Product() { ProductId = "stain remover", IsChilled = false, IsHazardous = true });

            Products.Add(new Product() { ProductId = "bread", IsChilled = false, IsHazardous = false });
            Products.Add(new Product() { ProductId = "pasta", IsChilled = false, IsHazardous = false });
            Products.Add(new Product() { ProductId = "salt", IsChilled = false, IsHazardous = false });
            Products.Add(new Product() { ProductId = "bamba", IsChilled = false, IsHazardous = false });
            Products.Add(new Product() { ProductId = "apple", IsChilled = false, IsHazardous = false });
        }
    }
}
