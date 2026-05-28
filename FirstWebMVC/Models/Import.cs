using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class Import 
    {
        public int Id { get; set; } 

        public DateTime ImportDate { get; set; } 

        public ICollection<ImportDetail>? ImportDetails { get; set; } 
        
}
}