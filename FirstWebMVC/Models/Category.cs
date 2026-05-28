using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage=" Tên loại thiết bị không được để trống ")]
        public string Name { get; set;}
    }
}
