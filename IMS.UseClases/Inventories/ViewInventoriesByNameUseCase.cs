using IMS.CoreBusiness;
using IMS.UseClases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseClases.Inventories
{
    public class ViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;
        

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        } 

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);

        {
        
    }
}
