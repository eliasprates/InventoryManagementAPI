namespace InventoryManagementAPI.Models
{
    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string ProductsCollectionName { get; set; }
        public string SuppliersCollectionName { get; set; }
    }
}
