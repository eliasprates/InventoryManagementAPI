using InventoryManagementAPI.Models;
using InventoryManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        // GET: api/suppliers
        [HttpGet]
        public async Task<ActionResult<List<Supplier>>> Get()
        {
            var suppliers = await _supplierService.GetAllSuppliersAsync();
            return Ok(suppliers);
        }

        // GET: api/suppliers/{id}
        [HttpGet("{id:length(24)}", Name = "GetSupplier")]
        public async Task<ActionResult<Supplier>> Get(string id)
        {
            var supplier = await _supplierService.GetSupplierByIdAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(supplier);
        }

        // POST: api/suppliers
        [HttpPost]
        public async Task<ActionResult<Supplier>> Create(Supplier supplier)
        {
            await _supplierService.CreateSupplierAsync(supplier);

            // Retorna o fornecedor recém-criado com o link para acessá-lo.
            return CreatedAtRoute("GetSupplier", new { id = supplier.Id }, supplier);
        }

        // PUT: api/suppliers/{id}
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Supplier supplierIn)
        {
            var supplier = await _supplierService.GetSupplierByIdAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            await _supplierService.UpdateSupplierAsync(id, supplierIn);

            return NoContent();
        }

        // DELETE: api/suppliers/{id}
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var supplier = await _supplierService.GetSupplierByIdAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            await _supplierService.DeleteSupplierAsync(id);

            return NoContent();
        }
    }
}