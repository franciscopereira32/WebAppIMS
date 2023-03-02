using IMS.CoreBusiness;
using IMS.UseClases.PluginInterfaces;

namespace IMS.UseClases
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory { InventoryID = 1, InventoryName = "Road Bike", Quantity = 10, price = 2 },
            }
        }

        public Task<IEnumerete<Inventory>> GetIventoryByNameAsyncy(string name)
        {
            throw new NotImplementedException();
        }

    }
}