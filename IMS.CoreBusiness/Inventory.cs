namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public string Name { get; set; } = string.Empty;  
        public int Quantity { get; set; } 
        public double Price { get; set; }   

    }
}