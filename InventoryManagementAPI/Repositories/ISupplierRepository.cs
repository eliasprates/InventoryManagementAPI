using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Repositories
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllAsync();
        Task<Supplier> GetByIdAsync(string id);
        Task CreateAsync(Supplier supplier);
        Task UpdateAsync(string id, Supplier supplier);
        Task DeleteAsync(string id);
    }
}
