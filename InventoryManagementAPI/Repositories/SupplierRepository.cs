using InventoryManagementAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace InventoryManagementAPI.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly IMongoCollection<Supplier> _suppliers;

        public SupplierRepository(IOptions<MongoDBSettings> settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.Value.DatabaseName);
            _suppliers = database.GetCollection<Supplier>(settings.Value.SuppliersCollectionName);
        }

        public async Task<List<Supplier>> GetAllAsync()
        {
            return await _suppliers.Find(supplier => true).ToListAsync();
        }

        public async Task<Supplier> GetByIdAsync(string id)
        {
            return await _suppliers.Find(supplier => supplier.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Supplier supplier)
        {
            await _suppliers.InsertOneAsync(supplier);
        }

        public async Task UpdateAsync(string id, Supplier supplier)
        {
            await _suppliers.ReplaceOneAsync(s => s.Id == id, supplier);
        }

        public async Task DeleteAsync(string id)
        {
            await _suppliers.DeleteOneAsync(s => s.Id == id);
        }
    }
}
