using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace InventoryManagementAPI.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string SupplierId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
