using InventoryManagementAPI.Models;
using InventoryManagementAPI.Repositories;

namespace InventoryManagementAPI.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            return await _supplierRepository.GetAllAsync();
        }

        public async Task<Supplier> GetSupplierByIdAsync(string id)
        {
            return await _supplierRepository.GetByIdAsync(id);
        }

        public async Task CreateSupplierAsync(Supplier supplier)
        {
            await _supplierRepository.CreateAsync(supplier);
        }

        public async Task UpdateSupplierAsync(string id, Supplier supplier)
        {
            await _supplierRepository.UpdateAsync(id, supplier);
        }

        public async Task DeleteSupplierAsync(string id)
        {
            await _supplierRepository.DeleteAsync(id);
        }
    }
}
