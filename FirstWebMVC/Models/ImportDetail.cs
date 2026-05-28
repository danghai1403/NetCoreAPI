using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class ImportDetail 
    {
        public int Id { get; set; } 

        public int ImportId { get; set; } 
        public Import? Import { get; set; } 

        public int DeviceId { get; set; } 
        public Device? Device { get; set; }

        public int Quantity { get; set; } 

        public decimal Price { get; set; } 

        public decimal Total => Quantity * Price; 
        
    }
}