using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
}
}