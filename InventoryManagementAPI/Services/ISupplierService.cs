using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Services
{
    public interface ISupplierService
    {
        Task<List<Supplier>> GetAllSuppliersAsync();
        Task<Supplier> GetSupplierByIdAsync(string id);
        Task CreateSupplierAsync(Supplier supplier);
        Task UpdateSupplierAsync(string id, Supplier supplier);
        Task DeleteSupplierAsync(string id);
    }
}
