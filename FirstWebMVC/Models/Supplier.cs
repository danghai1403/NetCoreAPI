using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required(ErrorMessage=" Tên không được để trống ")]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}