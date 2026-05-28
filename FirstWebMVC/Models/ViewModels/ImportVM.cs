namespace FirstWebMVC.Models.ViewModels
{
    public class ImportVM
    {
        public List<ImportItemVM> Items { get; set; } 
    
    }

    public class ImportItemVM
    {
        public int DeviceId { get; set; } 

        public int Quantity { get; set; } 

        public decimal Price { get; set; } 
    }
}