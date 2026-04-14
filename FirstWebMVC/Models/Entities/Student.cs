using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FirstWebMVC.Models.Entities;

namespace FirstWebMVC.Models.Entities

{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string StudentCode { get; set; }
        public string FullName { get; set; }

        // Khóa ngoại
        public int FacultyID { get; set; }

        // Navigation property
        [ForeignKey("FacultyID")]
        public Faculty Faculty { get; set; }
    }
}