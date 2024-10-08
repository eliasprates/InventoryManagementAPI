﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace InventoryManagementAPI.Models
{
    public class Supplier
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }
}
