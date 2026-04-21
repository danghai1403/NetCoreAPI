using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities
{
    public class Customer
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "Tên không được được để trống")]
        public string Name { get; set;}
        [EmailAddress]
        public string Email { get; set;}
        [Phone]
        public string Phone { get; set;}
        public ICollection<Order> Orders { get; set; }
    }
}