using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; } = null;
        public int CategoryId { get; set; }
         public Category? Category { get; set; }
         public int Quantity { get; set; } = 0;
    
    }
}