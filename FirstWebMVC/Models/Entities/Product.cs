using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models.Entities
{
    public class Product
    {
        public int Id { get; set;}
        [Required]
        public string ProductName { get; set;}
        [Range(0,1000)]
        public decimal Price { get; set;}
        public int Stock { get; set;}
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }

}